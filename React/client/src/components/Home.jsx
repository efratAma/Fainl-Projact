import React from 'react';
import LoginIcon from '../components/Login';
import { Link } from 'react-router-dom';
import { useLocation } from 'react-router-dom';

export default function Home() {
  const location = useLocation();

  const isActive = (path) => location.pathname === path;

  return (
    <div className="min-h-screen bg-[#f9f8f6] font-sans text-gray-900">
      {/* <LoginIcon /> */}
      {/* <nav className="bg-white shadow-sm border-b border-gray-100 h-28 px-10 flex items-center justify-between">
        <div className="flex items-center space-x-2">
          <img src="/logo.png" alt="Logo" className="h-24" />
        </div>

        <div className="flex items-center space-x-6 text-sm">
          <Link
            to="/projects"
            className={`hover:text-[#b38e44] ${isActive('/projects') ? 'border-b-2 border-[#b38e44] pb-1' : ''
              }`}
          >
            קצת עלינו
          </Link>
          <Link
            to="/projects"
            className={`hover:text-[#b38e44] ${isActive('/projects') ? 'border-b-2 border-[#b38e44] pb-1' : ''
              }`}
          >
          הפרויקטים שלנו
          </Link>
        </div>
      </nav> */}

      <header
        className="text-center py-24 px-6 bg-cover bg-center bg-no-repeat"
        style={{ backgroundImage: "url('/building-header.jpg')" }}
      >
        <div className="bg-white/80 p-8 max-w-3xl mx-auto rounded-xl shadow">
          <img
            src="/logo.png"
            alt="Prime Land Logo"
            className="mx-auto h-32 mb-6"
          />
          <h1 className="text-4xl md:text-5xl font-bold text-[#b38e44] mb-4">
            השקעות נדל״ן חכמות
          </h1>
          <p className="text-lg md:text-xl text-gray-700 mb-6">
            פלטפורמה להשקעות נדל״ן איכותיות בארץ ובעולם – עם שקיפות מלאה וביטחון.
          </p>
          <Link
            to="/projects"
            className="inline-block bg-[#b38e44] hover:bg-[#a27f3d] text-white font-medium px-8 py-3 rounded-lg shadow transition"
          >
            צפו בכל הפרויקטים
          </Link>
        </div>
      </header>

      {/* Features */}
      <section className="py-20 px-4 max-w-6xl mx-auto text-center">
        <h2 className="text-3xl font-bold mb-12 text-[#1d1d1f]">למה PRIME LAND?</h2>
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          <Feature icon="📈" title="תשואות גבוהות">
            פרויקטים עם ניתוח כלכלי מבוסס וצפי רווחים ברור
          </Feature>
          <Feature icon="🧠" title="ניסיון והובלה">
            ליווי מקצועי של מומחי נדל״ן מהשוק הישראלי והבינלאומי
          </Feature>
          <Feature icon="🌍" title="השקעות גלובליות">
            הזדמנויות בארץ, באירופה ובארה״ב עם ניתוח סיכונים
          </Feature>
          <Feature icon="🤝" title="שקיפות וביטחון">
            מידע מלא, דוחות פתוחים, ניהול כספים בטוח ומפוקח
          </Feature>
        </div>
      </section>
      <footer className="bg-white border-t border-gray-200 py-6 text-center text-sm text-gray-500">
        &copy; {new Date().getFullYear()} PRIME LAND - כל הזכויות שמורות.
      </footer>
    </div>
  );
}

function Feature({ icon, title, children }) {
  return (
    <div className="bg-white rounded-xl shadow-md p-6 hover:shadow-xl transition text-right">
      <div className="text-4xl mb-3">{icon}</div>
      <h3 className="text-lg font-semibold mb-1 text-[#1d1d1f]">{title}</h3>
      <p className="text-gray-600">{children}</p>
    </div>
  );
}
