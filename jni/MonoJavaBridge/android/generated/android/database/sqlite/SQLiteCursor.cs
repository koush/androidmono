namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteCursor : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteCursor()
		{
			InitJNI();
		}
		protected SQLiteCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize4698;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._finalize4698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._finalize4698);
		}
		internal static global::MonoJavaBridge.MethodId _close4699;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._close4699);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._close4699);
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4700;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._getCount4700);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getCount4700);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4701;
		public override int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._getColumnIndex4701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnIndex4701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4702;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._getColumnNames4702)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnNames4702)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4703;
		public override void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._deactivate4703);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._deactivate4703);
		}
		internal static global::MonoJavaBridge.MethodId _requery4704;
		public override bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._requery4704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._requery4704);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4705;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4706;
		public override bool onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._onMove4706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._onMove4706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWindow4707;
		public override void setWindow(android.database.CursorWindow arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._setWindow4707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setWindow4707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.sqlite.SQLiteDatabase Database
		{
			get
			{
				return getDatabase();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabase4708;
		public virtual global::android.database.sqlite.SQLiteDatabase getDatabase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._getDatabase4708)) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getDatabase4708)) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionArguments4709;
		public virtual void setSelectionArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor._setSelectionArguments4709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setSelectionArguments4709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteCursor4710;
		public SQLiteCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._SQLiteCursor4710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursor"));
			global::android.database.sqlite.SQLiteCursor._finalize4698 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "finalize", "()V");
			global::android.database.sqlite.SQLiteCursor._close4699 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteCursor._getCount4700 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getCount", "()I");
			global::android.database.sqlite.SQLiteCursor._getColumnIndex4701 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteCursor._getColumnNames4702 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.sqlite.SQLiteCursor._deactivate4703 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "deactivate", "()V");
			global::android.database.sqlite.SQLiteCursor._requery4704 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "requery", "()Z");
			global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4705 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.sqlite.SQLiteCursor._onMove4706 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "onMove", "(II)Z");
			global::android.database.sqlite.SQLiteCursor._setWindow4707 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::android.database.sqlite.SQLiteCursor._getDatabase4708 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteCursor._setSelectionArguments4709 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "setSelectionArguments", "([Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteCursor._SQLiteCursor4710 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V");
		}
	}
}
