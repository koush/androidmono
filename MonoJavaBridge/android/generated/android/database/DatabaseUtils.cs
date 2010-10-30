namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatabaseUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatabaseUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InsertHelper : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected InsertHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual long replace(android.content.ContentValues arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "replace", "(Landroid/content/ContentValues;)J", ref global::android.database.DatabaseUtils.InsertHelper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "close", "()V", ref global::android.database.DatabaseUtils.InsertHelper._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual long insert(android.content.ContentValues arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "insert", "(Landroid/content/ContentValues;)J", ref global::android.database.DatabaseUtils.InsertHelper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual long execute()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "execute", "()J", ref global::android.database.DatabaseUtils.InsertHelper._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual int getColumnIndex(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I", ref global::android.database.DatabaseUtils.InsertHelper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual void bind(int arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IZ)V", ref global::android.database.DatabaseUtils.InsertHelper._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual void bind(int arg0, byte[] arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(I[B)V", ref global::android.database.DatabaseUtils.InsertHelper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void bind(int arg0, float arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IF)V", ref global::android.database.DatabaseUtils.InsertHelper._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual void bind(int arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ILjava/lang/String;)V", ref global::android.database.DatabaseUtils.InsertHelper._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual void bind(int arg0, long arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IJ)V", ref global::android.database.DatabaseUtils.InsertHelper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual void bind(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(II)V", ref global::android.database.DatabaseUtils.InsertHelper._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual void bind(int arg0, double arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ID)V", ref global::android.database.DatabaseUtils.InsertHelper._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual void bindNull(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "bindNull", "(I)V", ref global::android.database.DatabaseUtils.InsertHelper._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public virtual void prepareForInsert()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForInsert", "()V", ref global::android.database.DatabaseUtils.InsertHelper._m13);
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public virtual void prepareForReplace()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForReplace", "()V", ref global::android.database.DatabaseUtils.InsertHelper._m14);
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public InsertHelper(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.DatabaseUtils.InsertHelper._m15.native == global::System.IntPtr.Zero)
					global::android.database.DatabaseUtils.InsertHelper._m15 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			public static int TABLE_INFO_PRAGMA_DEFAULT_INDEX
			{
				get
				{
					return 4;
				}
			}
			static InsertHelper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.DatabaseUtils.InsertHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DatabaseUtils$InsertHelper"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void writeExceptionToParcel(android.os.Parcel arg0, java.lang.Exception arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m0.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void readExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m1.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionFromParcel", "(Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void readExceptionWithFileNotFoundExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m2.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void readExceptionWithOperationApplicationExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m3.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void bindObjectToProgram(android.database.sqlite.SQLiteProgram arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m4.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void appendEscapedSQLString(java.lang.StringBuilder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m5.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String sqlEscapeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m6.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void appendValueToSql(java.lang.StringBuilder arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m7.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m7 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String getCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m8.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m8 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String getHexCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m9.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m9 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void dumpCursor(android.database.Cursor arg0, java.io.PrintStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m10.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m10 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void dumpCursor(android.database.Cursor arg0, java.lang.StringBuilder arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m11.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m11 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void dumpCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m12.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m12 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.String dumpCursorToString(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m13.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m13 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void dumpCurrentRow(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m14.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m14 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.io.PrintStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m15.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m15 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.lang.StringBuilder arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m16.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m16 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.lang.String dumpCurrentRowToString(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m17.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m17 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m18.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m18 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m19.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m19 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void cursorStringToInsertHelper(android.database.Cursor arg0, java.lang.String arg1, android.database.DatabaseUtils.InsertHelper arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m20.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m20 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$InsertHelper;I)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m21.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m21 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m22.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m22 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m23.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m23 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m24.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m24 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void cursorDoubleToCursorValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m25.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m25 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void cursorDoubleToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m26.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m26 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void cursorRowToContentValues(android.database.Cursor arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m27.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m27 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static long queryNumEntries(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m28.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m28 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static long longForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m29.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m29 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static long longForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m30.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m30 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m31.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m31 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m32.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m32 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void cursorStringToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m33.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m33 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void cursorLongToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m34.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m34 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void cursorShortToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m35.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m35 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorShortToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void cursorIntToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m36.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m36 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void cursorFloatToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m37.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m37 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorFloatToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void cursorDoubleToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m38.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m38 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void createDbFromSqlStatements(android.content.Context arg0, java.lang.String arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m39.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m39 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public DatabaseUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DatabaseUtils._m40.native == global::System.IntPtr.Zero)
				global::android.database.DatabaseUtils._m40 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._m40);
			Init(@__env, handle);
		}
		static DatabaseUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DatabaseUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DatabaseUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
