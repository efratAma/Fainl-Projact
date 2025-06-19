import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios';

export default function SignupPage() {
  const [form, setForm] = useState({ name: '', email: '', password: '' });
  const [error, setError] = useState('');
  const [success, setSuccess] = useState('');
  const navigate = useNavigate();

  const handleChange = (e) =>
    setForm({ ...form, [e.target.name]: e.target.value });

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError('');
    setSuccess('');

    if (!form.name || !form.email || !form.password) {
      setError('נא למלא את כל השדות');
      return;
    }

    try {
      const res = await axios.post('http://localhost:3001/api/register', form);
      if (res.data.success) {
        setSuccess('נרשמת בהצלחה! מועבר לכניסה...');
        setTimeout(() => navigate('/login'), 2000);
      } else {
        setError(res.data.message || 'שגיאה בעת הרשמה');
      }
    } catch (err) {
      setError(err.response?.data?.message || 'אירעה שגיאה בשרת');
    }
  };

  return (
    <div className="min-h-screen grid grid-cols-1 md:grid-cols-2">
      {/* צד שמאל – מידע */}  
      <div className="hidden md:flex bg-gradient-to-br from-teal-600 to-teal-400 text-white flex-col justify-center items-center p-12">
        <h1 className="text-4xl font-extrabold mb-4">הצטרף אלינו</h1>
        <p className="text-lg text-center max-w-sm">
          פתח חשבון והשקיע בנדל״ן בצורה חכמה ובטוחה.
        </p>
      </div>

      {/* צד ימין – טופס הרשמה */}
      <div className="flex items-center justify-center bg-white px-6 py-12">
        <div className="w-full max-w-md">
          <h2 className="text-2xl font-bold text-gray-800 mb-6 text-center">הרשמה</h2>

          {error && (
            <div className="bg-red-100 text-red-600 text-sm p-2 mb-4 rounded text-center">
              {error}
            </div>
          )}
          {success && (
            <div className="bg-green-100 text-green-600 text-sm p-2 mb-4 rounded text-center">
              {success}
            </div>
          )}

          <form onSubmit={handleSubmit} className="space-y-5">
            <div>
              <label className="block text-sm text-gray-600 mb-1">שם מלא</label>
              <input
                type="text"
                name="name"
                value={form.name}
                onChange={handleChange}
                className="w-full border border-gray-300 rounded-lg px-4 py-2 focus:outline-none focus:ring-2 focus:ring-teal-500"
                placeholder="ישראל ישראלי"
              />
            </div>

            <div>
              <label className="block text-sm text-gray-600 mb-1">אימייל</label>
              <input
                type="email"
                name="email"
                value={form.email}
                onChange={handleChange}
                className="w-full border border-gray-300 rounded-lg px-4 py-2 focus:outline-none focus:ring-2 focus:ring-teal-500"
                placeholder="email@example.com"
              />
            </div>

            <div>
              <label className="block text-sm text-gray-600 mb-1">סיסמה</label>
              <input
                type="password"
                name="password"
                value={form.password}
                onChange={handleChange}
                className="w-full border border-gray-300 rounded-lg px-4 py-2 focus:outline-none focus:ring-2 focus:ring-teal-500"
                placeholder="******"
              />
            </div>

            <button
              type="submit"
              className="w-full bg-teal-600 hover:bg-teal-700 text-white font-semibold py-2 rounded-lg shadow transition"
            >
              הירשם
            </button>
          </form>

          <p className="text-sm text-center text-gray-500 mt-6">
            כבר יש לך חשבון? <a href="/login" className="text-teal-600 hover:underline">התחבר</a>
          </p>
        </div>
      </div>
    </div>
  );
}
