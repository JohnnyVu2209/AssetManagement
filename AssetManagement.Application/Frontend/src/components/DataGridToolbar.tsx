import React from "react";
import {
  GridToolbarContainer,
  GridToolbarColumnsButton,
  GridToolbarFilterButton,
  GridToolbarExport,
  GridToolbarDensitySelector,
} from "@mui/x-data-grid";
function DataGridToolbar() {
  return (
    <GridToolbarContainer>
      <GridToolbarColumnsButton
        sx={{
          fontFamily: "Nunito Sans",
          color: "black",
          "&:hover": {
            color: "#E41F28",
          },
        }}
      />
      <GridToolbarFilterButton
        sx={{
          fontFamily: "Nunito Sans",
          color: "black",
          "&:hover": {
            color: "#E41F28",
          },
        }}
      />
      {/* <GridToolbarDensitySelector /> */}
      <GridToolbarExport
        sx={{
          fontFamily: "Nunito Sans",
          color: "black",
          "&:hover": {
            color: "#E41F28",
          },
          "& .MuiTypography-root": {
            color: "black",
            fontSize: 20,
          },
        }}
      />
    </GridToolbarContainer>
  );
}

export default DataGridToolbar;
