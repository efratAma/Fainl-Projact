import { createSlice } from "@reduxjs/toolkit";


const projectsSlice = createSlice({
    name: "projects",
    initialState: {
        projects: [],
        error: false,
        loading: false,
        filter: ''
    },
    reducers: {
        changeFilter: (state, action) => {
            state.filter = action.payload;
        },
        addProject: (state, action) => {
     
    },
    deleteProject: (state, action) => {
      
    },
    },
    extraReducers: (builder) => {
        builder
            .addCase(fetchDataAsyncAction.pending, (state) => {
                state.loading = true;
                state.products = [];
                state.error = false;
            })
            .addCase(fetchDataAsyncAction.fulfilled, (state, action) => {
                state.loading = false;
                state.products = action.payload;
                state.error = false;
            })
            .addCase(fetchDataAsyncAction.rejected, (state) => {
                state.loading = false;
                state.products = [];
                state.error = true;
                
            })
    }
});

export const { changeFilter } = projectsSlice.actions;


export default projectsSlice.reducer;
