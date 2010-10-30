namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteCursor : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "finalize", "()V", ref global::android.database.sqlite.SQLiteCursor._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "close", "()V", ref global::android.database.sqlite.SQLiteCursor._m1);
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "getCount", "()I", ref global::android.database.sqlite.SQLiteCursor._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getColumnIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.sqlite.SQLiteCursor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.sqlite.SQLiteCursor._m4) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "deactivate", "()V", ref global::android.database.sqlite.SQLiteCursor._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "requery", "()Z", ref global::android.database.sqlite.SQLiteCursor._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.sqlite.SQLiteCursor._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "onMove", "(II)Z", ref global::android.database.sqlite.SQLiteCursor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.database.CursorWindow Window
		{
			set
			{
				setWindow(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setWindow(android.database.CursorWindow arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V", ref global::android.database.sqlite.SQLiteCursor._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.sqlite.SQLiteDatabase Database
		{
			get
			{
				return getDatabase();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.database.sqlite.SQLiteDatabase getDatabase()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", ref global::android.database.sqlite.SQLiteCursor._m10) as android.database.sqlite.SQLiteDatabase;
		}
		public new global::java.lang.String[] SelectionArguments
		{
			set
			{
				setSelectionArguments(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setSelectionArguments(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, "setSelectionArguments", "([Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteCursor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SQLiteCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._m12.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._m12 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SQLiteCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
