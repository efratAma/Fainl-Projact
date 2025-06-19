import React, { useState, useEffect } from 'react';

export default function Profile() {
  const [user, setUser] = useState({
    fullName: 'אפרת עמאור',
    email: 'efrat@example.com',
    role: 'משקיעה',
    joinDate: '2024-03-15'
  });

  return (
    <div className="min-h-screen bg-slate-50 p-6">
      <div className="max-w-3xl mx-auto bg-white rounded-2xl shadow-lg p-8">
        <h1 className="text-3xl font-bold mb-6 text-center text-teal-700">האזור האישי שלי</h1>

        <div className="grid gap-4 text-right">
          <div>
            <label className="font-semibold text-gray-600">שם מלא:</label>
            <div className="text-lg">{user.fullName}</div>
          </div>

          <div>
            <label className="font-semibold text-gray-600">אימייל:</label>
            <div className="text-lg">{user.email}</div>
          </div>

          <div>
            <label className="font-semibold text-gray-600">תפקיד:</label>
            <div className="text-lg">{user.role}</div>
          </div>

          <div>
            <label className="font-semibold text-gray-600">תאריך הצטרפות:</label>
            <div className="text-lg">{new Date(user.joinDate).toLocaleDateString('he-IL')}</div>
          </div>
        </div>

        <div className="mt-8 text-center">
          <button className="bg-teal-600 hover:bg-teal-700 text-white px-6 py-2 rounded-lg shadow">
            עריכת פרטים
          </button>
        </div>
      </div>
    </div>
  );
}
