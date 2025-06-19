import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';

export default function LoginPage() {
  const [form, setForm] = useState({ email: '', password: '' });
  const [error, setError] = useState('');
  const navigate = useNavigate();

  const handleChange = (e) =>
    setForm({ ...form, [e.target.name]: e.target.value });

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!form.email || !form.password) {
      setError('נא למלא את כל השדות');
      return;
    }
    if (form.email === 'admin@example.com' && form.password === '123456') {
      navigate('/dashboard');
    } else {
      setError('אימייל או סיסמה שגויים');
    }
  };

  return (
    <div className="min-h-screen grid grid-cols-1 md:grid-cols-2">
      {/* צד שמאל – רקע תדמיתי */}
      <div className="hidden md:flex bg-gradient-to-br from-teal-600 to-teal-400 text-white flex-col justify-center items-center p-12">
        <h1 className="text-4xl font-extrabold mb-4">השקעות נדל״ן</h1>
        <p className="text-lg text-center max-w-sm">
          התחבר לפלטפורמה החכמה שלנו והשקיע בנדל״ן עם כל הכלים שאתה צריך.
        </p>
      </div>

      {/* צד ימין – טופס התחברות */}
      <div className="flex items-center justify-center bg-white px-6 py-12">
        <div className="w-full max-w-md">
          <h2 className="text-2xl font-bold text-gray-800 mb-6 text-center">כניסה למערכת</h2>

          {error && (
            <div className="bg-red-100 text-red-600 text-sm p-2 mb-4 rounded text-center">
              {error}
            </div>
          )}

          <form onSubmit={handleSubmit} className="space-y-5">
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
            href="/profile"
              type="submit"
              className="w-full bg-teal-600 hover:bg-teal-700 text-white font-semibold py-2 rounded-lg shadow transition"
            >
              התחבר
            </button>
          </form>

          <p className="text-sm text-center text-gray-500 mt-6">
            אין לך חשבון? <a href="/signup" className="text-teal-600 hover:underline">הירשם כאן</a>
          </p>

        </div>
      </div>
    </div>
  );
}
