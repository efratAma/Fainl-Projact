import { Link } from 'react-router-dom';
import { useLocation } from 'react-router-dom';

export default function Navbar() {
    const location = useLocation();
    const isActive = (path) => location.pathname === path;
    return (
        <nav className="bg-white shadow-sm border-b border-gray-100 h-28 px-10 flex items-center justify-between">
            <div className="flex items-center space-x-2">
                <Link to="/">
                    <img src="/logo.png" alt="Logo" className="h-24" />
                </Link>
            </div>

            <div className="flex items-center space-x-6 text-sm">
                <Link
                    to="/"
                    className={`hover:text-[#b38e44] ${isActive('/') ? 'border-b-2 border-[#b38e44] pb-1' : ''
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
        </nav>
    );
}
