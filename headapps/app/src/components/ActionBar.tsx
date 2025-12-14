"use client";

import { addEscape } from "@/actions/add-escape";
import { addExplorer } from "@/actions/add-explorer";
import { addMustang } from "@/actions/add-mustang";

export const ActionBar = () => {
  return (
    <div className="mb-4 flex w-full justify-end">
      <form
        action={addExplorer}
        onSubmit={(e) => {
          e.currentTarget.reset();
          window.location.reload();
        }}
      >
        <button
          type="submit"
          className="rounded bg-blue-500 px-4 py-2 font-semibold text-white hover:bg-blue-600"
        >
          Add Explorer
        </button>
      </form>
      <form
        action={addMustang}
        onSubmit={(e) => {
          e.currentTarget.reset();
          window.location.reload();
        }}
      >
        <button
          type="submit"
          className="rounded bg-blue-500 px-4 py-2 font-semibold text-white hover:bg-blue-600"
        >
          Add Mustang
        </button>
      </form>
      <form
        action={addEscape}
        onSubmit={(e) => {
          e.currentTarget.reset();
          window.location.reload();
        }}
      >
        <button
          type="submit"
          className="rounded bg-blue-500 px-4 py-2 font-semibold text-white hover:bg-blue-600"
        >
          Add Escape
        </button>
      </form>
    </div>
  );
};
