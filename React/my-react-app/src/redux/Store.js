
import {projectsReducer} from './ProjectsSlice' 

const store = configureStore({
    reducer: {
        products: projectsReducer
              
    }
});

export default store;