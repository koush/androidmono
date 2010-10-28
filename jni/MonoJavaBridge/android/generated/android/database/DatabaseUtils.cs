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
			internal static global::MonoJavaBridge.MethodId _replace4604;
			public virtual long replace(android.content.ContentValues arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._replace4604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._replace4604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _close4605;
			public virtual void close()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._close4605);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._close4605);
			}
			internal static global::MonoJavaBridge.MethodId _insert4606;
			public virtual long insert(android.content.ContentValues arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._insert4606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._insert4606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _execute4607;
			public virtual long execute()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._execute4607);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._execute4607);
			}
			internal static global::MonoJavaBridge.MethodId _getColumnIndex4608;
			public virtual int getColumnIndex(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex4608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex4608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bind4609;
			public virtual void bind(int arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4610;
			public virtual void bind(int arg0, byte[] arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4611;
			public virtual void bind(int arg0, float arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4612;
			public virtual void bind(int arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4613;
			public virtual void bind(int arg0, long arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4614;
			public virtual void bind(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind4615;
			public virtual void bind(int arg0, double arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind4615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind4615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bindNull4616;
			public virtual void bindNull(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bindNull4616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bindNull4616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _prepareForInsert4617;
			public virtual void prepareForInsert()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert4617);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert4617);
			}
			internal static global::MonoJavaBridge.MethodId _prepareForReplace4618;
			public virtual void prepareForReplace()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace4618);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace4618);
			}
			internal static global::MonoJavaBridge.MethodId _InsertHelper4619;
			public InsertHelper(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._InsertHelper4619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
				global::android.database.DatabaseUtils.InsertHelper._replace4604 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "replace", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._close4605 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "close", "()V");
				global::android.database.DatabaseUtils.InsertHelper._insert4606 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "insert", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._execute4607 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "execute", "()J");
				global::android.database.DatabaseUtils.InsertHelper._getColumnIndex4608 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
				global::android.database.DatabaseUtils.InsertHelper._bind4609 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IZ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4610 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(I[B)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4611 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IF)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4612 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ILjava/lang/String;)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4613 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IJ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4614 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(II)V");
				global::android.database.DatabaseUtils.InsertHelper._bind4615 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ID)V");
				global::android.database.DatabaseUtils.InsertHelper._bindNull4616 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bindNull", "(I)V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForInsert4617 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForInsert", "()V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForReplace4618 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForReplace", "()V");
				global::android.database.DatabaseUtils.InsertHelper._InsertHelper4619 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeExceptionToParcel4621;
		public static void writeExceptionToParcel(android.os.Parcel arg0, java.lang.Exception arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._writeExceptionToParcel4621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionFromParcel4622;
		public static void readExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionFromParcel4622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionWithFileNotFoundExceptionFromParcel4623;
		public static void readExceptionWithFileNotFoundExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel4623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionWithOperationApplicationExceptionFromParcel4624;
		public static void readExceptionWithOperationApplicationExceptionFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel4624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindObjectToProgram4625;
		public static void bindObjectToProgram(android.database.sqlite.SQLiteProgram arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._bindObjectToProgram4625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _appendEscapedSQLString4626;
		public static void appendEscapedSQLString(java.lang.StringBuilder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendEscapedSQLString4626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqlEscapeString4627;
		public static global::java.lang.String sqlEscapeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._sqlEscapeString4627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendValueToSql4628;
		public static void appendValueToSql(java.lang.StringBuilder arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendValueToSql4628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey4629;
		public static global::java.lang.String getCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getCollationKey4629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHexCollationKey4630;
		public static global::java.lang.String getHexCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getHexCollationKey4630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor4631;
		public static void dumpCursor(android.database.Cursor arg0, java.io.PrintStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor4631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor4632;
		public static void dumpCursor(android.database.Cursor arg0, java.lang.StringBuilder arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor4632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor4633;
		public static void dumpCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor4633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursorToString4634;
		public static global::java.lang.String dumpCursorToString(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursorToString4634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow4635;
		public static void dumpCurrentRow(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow4635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow4636;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.io.PrintStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow4636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow4637;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.lang.StringBuilder arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow4637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRowToString4638;
		public static global::java.lang.String dumpCurrentRowToString(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRowToString4638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValues4639;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues4639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValues4640;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues4640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToInsertHelper4641;
		public static void cursorStringToInsertHelper(android.database.Cursor arg0, java.lang.String arg1, android.database.DatabaseUtils.InsertHelper arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToInsertHelper4641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValues4642;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues4642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValues4643;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues4643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValues4644;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues4644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValues4645;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues4645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToCursorValues4646;
		public static void cursorDoubleToCursorValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToCursorValues4646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToContentValues4647;
		public static void cursorDoubleToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToContentValues4647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorRowToContentValues4648;
		public static void cursorRowToContentValues(android.database.Cursor arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorRowToContentValues4648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _queryNumEntries4649;
		public static long queryNumEntries(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._queryNumEntries4649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longForQuery4650;
		public static long longForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery4650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longForQuery4651;
		public static long longForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery4651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stringForQuery4652;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery4652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stringForQuery4653;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery4653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValuesIfPresent4654;
		public static void cursorStringToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValuesIfPresent4654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValuesIfPresent4655;
		public static void cursorLongToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValuesIfPresent4655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorShortToContentValuesIfPresent4656;
		public static void cursorShortToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorShortToContentValuesIfPresent4656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValuesIfPresent4657;
		public static void cursorIntToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValuesIfPresent4657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorFloatToContentValuesIfPresent4658;
		public static void cursorFloatToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorFloatToContentValuesIfPresent4658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToContentValuesIfPresent4659;
		public static void cursorDoubleToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToContentValuesIfPresent4659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createDbFromSqlStatements4660;
		public static void createDbFromSqlStatements(android.content.Context arg0, java.lang.String arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._createDbFromSqlStatements4660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _DatabaseUtils4661;
		public DatabaseUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._DatabaseUtils4661);
			Init(@__env, handle);
		}
		static DatabaseUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DatabaseUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DatabaseUtils"));
			global::android.database.DatabaseUtils._writeExceptionToParcel4621 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V");
			global::android.database.DatabaseUtils._readExceptionFromParcel4622 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel4623 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel4624 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._bindObjectToProgram4625 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V");
			global::android.database.DatabaseUtils._appendEscapedSQLString4626 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._sqlEscapeString4627 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._appendValueToSql4628 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V");
			global::android.database.DatabaseUtils._getCollationKey4629 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._getHexCollationKey4630 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCursor4631 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCursor4632 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCursor4633 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCursorToString4634 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCurrentRow4635 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow4636 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow4637 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCurrentRowToString4638 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._cursorStringToContentValues4639 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorStringToContentValues4640 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorStringToInsertHelper4641 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$InsertHelper;I)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues4642 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues4643 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues4644 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues4645 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorDoubleToCursorValues4646 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorDoubleToContentValues4647 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorRowToContentValues4648 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._queryNumEntries4649 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery4650 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery4651 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._stringForQuery4652 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._stringForQuery4653 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._cursorStringToContentValuesIfPresent4654 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValuesIfPresent4655 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorShortToContentValuesIfPresent4656 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorShortToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorIntToContentValuesIfPresent4657 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorFloatToContentValuesIfPresent4658 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorFloatToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorDoubleToContentValuesIfPresent4659 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._createDbFromSqlStatements4660 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V");
			global::android.database.DatabaseUtils._DatabaseUtils4661 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
