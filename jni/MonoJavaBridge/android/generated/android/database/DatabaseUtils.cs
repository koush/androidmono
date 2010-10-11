namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatabaseUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatabaseUtils()
		{
			InitJNI();
		}
		protected DatabaseUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InsertHelper : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static InsertHelper()
			{
				InitJNI();
			}
			protected InsertHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _replace2689;
			public virtual long replace(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._replace2689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._replace2689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _close2690;
			public virtual void close() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._close2690);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._close2690);
			}
			internal static global::MonoJavaBridge.MethodId _insert2691;
			public virtual long insert(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._insert2691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._insert2691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _execute2692;
			public virtual long execute() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._execute2692);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._execute2692);
			}
			internal static global::MonoJavaBridge.MethodId _getColumnIndex2693;
			public virtual int getColumnIndex(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bind2694;
			public virtual void bind(int arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2695;
			public virtual void bind(int arg0, byte[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2696;
			public virtual void bind(int arg0, float arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2697;
			public virtual void bind(int arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2698;
			public virtual void bind(int arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2699;
			public virtual void bind(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bind2700;
			public virtual void bind(int arg0, double arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bind2700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _bindNull2701;
			public virtual void bindNull(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._bindNull2701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bindNull2701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _prepareForInsert2702;
			public virtual void prepareForInsert() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2702);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2702);
			}
			internal static global::MonoJavaBridge.MethodId _prepareForReplace2703;
			public virtual void prepareForReplace() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2703);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2703);
			}
			internal static global::MonoJavaBridge.MethodId _InsertHelper2704;
			public InsertHelper(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._InsertHelper2704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			public static int TABLE_INFO_PRAGMA_DEFAULT_INDEX
			{
				get
				{
					return 4;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.DatabaseUtils.InsertHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DatabaseUtils$InsertHelper"));
				global::android.database.DatabaseUtils.InsertHelper._replace2689 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "replace", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._close2690 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "close", "()V");
				global::android.database.DatabaseUtils.InsertHelper._insert2691 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "insert", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._execute2692 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "execute", "()J");
				global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2693 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
				global::android.database.DatabaseUtils.InsertHelper._bind2694 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IZ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2695 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(I[B)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2696 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IF)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2697 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ILjava/lang/String;)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2698 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IJ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2699 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(II)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2700 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ID)V");
				global::android.database.DatabaseUtils.InsertHelper._bindNull2701 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bindNull", "(I)V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2702 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForInsert", "()V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2703 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForReplace", "()V");
				global::android.database.DatabaseUtils.InsertHelper._InsertHelper2704 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.InsertHelper.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeExceptionToParcel2705;
		public static void writeExceptionToParcel(android.os.Parcel arg0, java.lang.Exception arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._writeExceptionToParcel2705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionFromParcel2706;
		public static void readExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionFromParcel2706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionWithFileNotFoundExceptionFromParcel2707;
		public static void readExceptionWithFileNotFoundExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel2707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readExceptionWithOperationApplicationExceptionFromParcel2708;
		public static void readExceptionWithOperationApplicationExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel2708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindObjectToProgram2709;
		public static void bindObjectToProgram(android.database.sqlite.SQLiteProgram arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._bindObjectToProgram2709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _appendEscapedSQLString2710;
		public static void appendEscapedSQLString(java.lang.StringBuilder arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendEscapedSQLString2710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqlEscapeString2711;
		public static global::java.lang.String sqlEscapeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._sqlEscapeString2711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendValueToSql2712;
		public static void appendValueToSql(java.lang.StringBuilder arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendValueToSql2712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey2713;
		public static global::java.lang.String getCollationKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getCollationKey2713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHexCollationKey2714;
		public static global::java.lang.String getHexCollationKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getHexCollationKey2714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor2715;
		public static void dumpCursor(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor2716;
		public static void dumpCursor(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursor2717;
		public static void dumpCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCursorToString2718;
		public static global::java.lang.String dumpCursorToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursorToString2718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow2719;
		public static void dumpCurrentRow(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow2720;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRow2721;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpCurrentRowToString2722;
		public static global::java.lang.String dumpCurrentRowToString(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRowToString2722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValues2723;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues2723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValues2724;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues2724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToInsertHelper2725;
		public static void cursorStringToInsertHelper(android.database.Cursor arg0, java.lang.String arg1, android.database.DatabaseUtils.InsertHelper arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToInsertHelper2725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValues2726;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues2726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValues2727;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues2727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValues2728;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues2728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValues2729;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues2729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToCursorValues2730;
		public static void cursorDoubleToCursorValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToCursorValues2730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToContentValues2731;
		public static void cursorDoubleToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToContentValues2731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cursorRowToContentValues2732;
		public static void cursorRowToContentValues(android.database.Cursor arg0, android.content.ContentValues arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorRowToContentValues2732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _queryNumEntries2733;
		public static long queryNumEntries(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._queryNumEntries2733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longForQuery2734;
		public static long longForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery2734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longForQuery2735;
		public static long longForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery2735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stringForQuery2736;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery2736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stringForQuery2737;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery2737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _cursorStringToContentValuesIfPresent2738;
		public static void cursorStringToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValuesIfPresent2738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorLongToContentValuesIfPresent2739;
		public static void cursorLongToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValuesIfPresent2739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorShortToContentValuesIfPresent2740;
		public static void cursorShortToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorShortToContentValuesIfPresent2740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorIntToContentValuesIfPresent2741;
		public static void cursorIntToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValuesIfPresent2741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorFloatToContentValuesIfPresent2742;
		public static void cursorFloatToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorFloatToContentValuesIfPresent2742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cursorDoubleToContentValuesIfPresent2743;
		public static void cursorDoubleToContentValuesIfPresent(android.database.Cursor arg0, android.content.ContentValues arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToContentValuesIfPresent2743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createDbFromSqlStatements2744;
		public static void createDbFromSqlStatements(android.content.Context arg0, java.lang.String arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._createDbFromSqlStatements2744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _DatabaseUtils2745;
		public DatabaseUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._DatabaseUtils2745);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DatabaseUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DatabaseUtils"));
			global::android.database.DatabaseUtils._writeExceptionToParcel2705 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V");
			global::android.database.DatabaseUtils._readExceptionFromParcel2706 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel2707 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel2708 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._bindObjectToProgram2709 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V");
			global::android.database.DatabaseUtils._appendEscapedSQLString2710 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._sqlEscapeString2711 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._appendValueToSql2712 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V");
			global::android.database.DatabaseUtils._getCollationKey2713 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._getHexCollationKey2714 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCursor2715 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCursor2716 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCursor2717 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCursorToString2718 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCurrentRow2719 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow2720 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow2721 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCurrentRowToString2722 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._cursorStringToContentValues2723 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorStringToContentValues2724 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorStringToInsertHelper2725 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$InsertHelper;I)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues2726 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues2727 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues2728 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues2729 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorDoubleToCursorValues2730 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorDoubleToContentValues2731 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorRowToContentValues2732 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._queryNumEntries2733 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery2734 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery2735 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._stringForQuery2736 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._stringForQuery2737 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._cursorStringToContentValuesIfPresent2738 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValuesIfPresent2739 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorShortToContentValuesIfPresent2740 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorShortToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorIntToContentValuesIfPresent2741 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorFloatToContentValuesIfPresent2742 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorFloatToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorDoubleToContentValuesIfPresent2743 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._createDbFromSqlStatements2744 = @__env.GetStaticMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V");
			global::android.database.DatabaseUtils._DatabaseUtils2745 = @__env.GetMethodIDNoThrow(global::android.database.DatabaseUtils.staticClass, "<init>", "()V");
		}
	}
}
