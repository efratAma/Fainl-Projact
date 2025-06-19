// import { useDispatch, useSelector } from "react-redux";
// import { useNavigate } from "react-router-dom";
// import Project from "./Project";
// import { fetchDataAsyncAction } from "../../redux/Thunk";

// const Projects=()=>{
//  const dispatch = useDispatch();
//   const navigate = useNavigate();

//   const { projects, loading, error } = useSelector((state) => state.projects);
//   const filter = useSelector((state) => state.projects.filter);

//   useEffect(() => {
//     dispatch(fetchDataAsyncAction());
//   }, [dispatch]);

//   useEffect(() => {
//     if (error) {
//       navigate("/error");
//     }
//   }, [error, navigate]);

//   const filteredprojects = projects.filter((project) => {
//     if (filter === '') return true;
//     return project.title.toLowerCase().includes(filter.toLowerCase());
//   });
    
//     return(
//         <>
//  <div className="container align-items-start p-0">
//       <div className="row align-items-start mb-4">
//         <div className="col-6"></div>
//       </div>
//       {loading && (
//         <div className="loading-wrapper">
//           <img src={loadingIcon} alt="Loading" />
//         </div>
//       )}     
//       <div className="projects">
//         {filteredprojects.length ? (
//           filteredprojects.map((project) => (
//             <div className="project" key={project.id}>
//               <Project product={project} />
//             </div>
            
//           ))
//         ) : (
//           <p>No projects found.</p>
//         )}
//       </div>
//       </div>
//         </>
//     )
// }
// export default Projects;


import React from "react";

const Projects = () => (
  <section className="container mx-auto py-16">
    <h1 className="text-3xl font-bold mb-4 text-center">פרויקטים</h1>
    <p className="text-center text-muted-foreground">רשימת הפרויקטים תוצג כאן.</p>
  </section>
);

export default Projects;
