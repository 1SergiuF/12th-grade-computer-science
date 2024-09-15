export interface MyButtonProps
  extends React.ButtonHTMLAttributes<HTMLButtonElement> {
  myTitle?: string | string[] | readonly string[] | number;
  disable?: boolean;
}
