import React from 'react';
import { useNavigate } from 'react-router-dom';
import { FaUserCircle } from 'react-icons/fa';

export default function Login() {
  const navigate = useNavigate();

  return (
    <button
      onClick={() => navigate('/login')}
      className="flex items-center gap-2 px-4 py-2 bg-white border border-gray-300 rounded-full shadow-sm hover:shadow-md transition hover:bg-gray-100 text-gray-700 hover:text-teal-600"
    >
      <div className="bg-teal-100 p-2 rounded-full">
        <FaUserCircle size={24} />
      </div>
      <span className="font-medium text-sm sm:text-base">התחברות</span>
    </button>
  );
}
