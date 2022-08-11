import { TableCell, TableHead, TableSortLabel } from '@mui/material';
import React from 'react'
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';

export type Order = 'asc' | 'desc';

interface HeadCell {
    id: string
    label: string
}

interface TableProps {
    onRequestSort: (event: React.MouseEvent<unknown>, property: any) => void;
    order: Order;
    orderBy: string;
    headLabel: HeadCell[]
}

function descendingComparator<T>(a: T, b: T, orderBy: keyof T) {
    if (b[orderBy] < a[orderBy]) {
        return -1;
    }
    if (b[orderBy] > a[orderBy]) {
        return 1;
    }
    return 0;
}

export function getComparator<Key extends keyof any>(
    order: Order,
    orderBy: Key,
): (
        a: { [key in Key]: number | string },
        b: { [key in Key]: number | string },
    ) => number {
    return order === 'desc'
        ? (a, b) => descendingComparator(a, b, orderBy)
        : (a, b) => -descendingComparator(a, b, orderBy);
}

export function stableSort<T>(array: readonly T[], comparator: (a: T, b: T) => number) {
    const stabilizedThis = array.map((el, index) => [el, index] as [T, number]);
    stabilizedThis.sort((a, b) => {
        const order = comparator(a[0], b[0]);
        if (order !== 0) {
            return order;
        }
        return a[1] - b[1];
    });
    return stabilizedThis.map((el) => el[0]);
}

const TableHeader = (props: TableProps) => {
    const { order, orderBy, onRequestSort, headLabel } =
      props;
  
    const createSortHandler =
      (property: any) => (event: React.MouseEvent<unknown>) => {
        onRequestSort(event, property);
      };
  
    return (
      <TableHead>
        {headLabel.map(item => (
          <TableCell
            key={item.id}
            sortDirection={orderBy === item.id ? order : false}
            sx={{fontWeight:"bold"}}
          >
            <TableSortLabel
              active={orderBy === item.id}
              direction={orderBy === item.id ? order : 'asc'}
              onClick={createSortHandler(item.id)}
              IconComponent={ArrowDropDownIcon}
            >
              {item.label}
            </TableSortLabel>
          </TableCell>
        ))}
      </TableHead>
    )
  }

export default TableHeader