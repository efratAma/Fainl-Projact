import React from 'react';
import LoginIcon from '../components/Login';

export default function Home() {
  return (
    <div className="min-h-screen bg-gradient-to-b from-white to-slate-100 font-sans text-gray-800">
      <LoginIcon />
      <p className="text-red-600 text-xl font-bold text-center mt-6">
        בדיקה: הטקסט הזה אמור להיות בצבע אדום
      </p>

      <header className="text-center py-20 px-4 bg-gradient-to-r from-emerald-500 to-teal-600 text-white">
        <h1 className="text-4xl md:text-6xl font-bold mb-4">
          השקעות נדל״ן חכמות שמובילות להצלחה
        </h1>
        <p className="text-lg md:text-xl mb-6">
          הצטרפו לפלטפורמה שמחברת אתכם להזדמנויות הנדל"ן הכי משתלמות בארץ ובעולם
        </p>
        <button className="bg-white text-teal-700 hover:bg-gray-100 font-semibold px-6 py-3 rounded-xl shadow-md transition">
          התחילו להשקיע עכשיו
        </button>
      </header>

      <section className="py-16 px-4 max-w-6xl mx-auto text-center">
        <h2 className="text-3xl font-semibold mb-10">למה לבחור בנו?</h2>
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          <Feature icon="📈" title="תשואות גבוהות">
            ניתוחים מקצועיים שמובילים לבחירות השקעה מניבות
          </Feature>
          <Feature icon="🧠" title="ידע וניסיון">
            מלווה מומחים עם שנים של ניסיון בשוק הנדל"ן
          </Feature>
          <Feature icon="🌍" title="נדל״ן גלובלי">
            השקעות גם בישראל וגם מעבר לים
          </Feature>
          <Feature icon="🤝" title="שקיפות מלאה">
            דוחות מלאים, גישה חופשית למידע וליווי אישי
          </Feature>
        </div>
      </section>

      <footer className="bg-gray-100 py-6 text-center text-sm text-gray-500">
        &copy; {new Date().getFullYear()} השקעות נדל"ן בע"מ. כל הזכויות שמורות.
      </footer>
    </div>
  );
}

function Feature({ icon, title, children }) {
  return (
    <div className="bg-white rounded-2xl shadow-lg p-6 hover:shadow-xl transition">
      <div className="text-4xl mb-4">{icon}</div>
      <h3 className="text-xl font-bold mb-2">{title}</h3>
      <p className="text-gray-600">{children}</p>
    </div>
  );
}
