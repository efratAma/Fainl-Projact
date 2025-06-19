import React, { useEffect, useState } from 'react';
import api from '../services/api'; // ודאי שהנתיב נכון בהתאם למיקום הקובץ

export default function Projects() {
    const [projects, setProjects] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState('');

    useEffect(() => {
        api
            .get('/api/Project/GetAllProjects')
            .then((res) => {
                setProjects(res.data);
                setLoading(false);
            })
            .catch((err) => {
                setError('שגיאה בטעינת הפרויקטים');
                setLoading(false);
            });
    }, []);

    if (loading) return <div className="text-center p-4">טוען...</div>;
    if (error) return <div className="text-red-600 text-center">{error}</div>;

    return (
        <div className="max-w-4xl mx-auto py-10 px-4">
            <h1 className="text-3xl font-bold text-center mb-8">רשימת פרויקטים</h1>

            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                {projects.map((project) => (
                    <div key={project.id} className="border p-4 rounded-lg shadow hover:shadow-lg transition">
                        <h2 className="text-xl font-semibold mb-2">{project.projectName}</h2>
                        <p className="text-gray-600">עיר: {project.city}</p>
                        <p className="text-gray-600">דירות: {project.numberOfApartments}</p>
                        <p className="text-gray-600">מיקוד: {project.zipCode}</p>
                    </div>
                ))}
            </div>
        </div>
    );
}
