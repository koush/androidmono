namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DatabaseUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DatabaseUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.DatabaseUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.DatabaseUtils(@__env);
			}
		}
		protected DatabaseUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class InsertHelper : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static InsertHelper()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.DatabaseUtils.InsertHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.database.DatabaseUtils.InsertHelper(@__env);
				}
			}
			protected InsertHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _replace2341;
			public virtual long replace(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper._replace2341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._replace2341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _close2342;
			public virtual void close() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._close2342);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._close2342);
			}
			internal static global::net.sf.jni4net.jni.MethodId _insert2343;
			public virtual long insert(android.content.ContentValues arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper._insert2343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._insert2343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _execute2344;
			public virtual long execute() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.database.DatabaseUtils.InsertHelper._execute2344);
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._execute2344);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2345;
			public virtual int getColumnIndex(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2346;
			public virtual void bind(int arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2347;
			public virtual void bind(int arg0, byte[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2348;
			public virtual void bind(int arg0, float arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2349;
			public virtual void bind(int arg0, java.lang.String arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2350;
			public virtual void bind(int arg0, long arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2351;
			public virtual void bind(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bind2352;
			public virtual void bind(int arg0, double arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bind2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bind2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bindNull2353;
			public virtual void bindNull(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._bindNull2353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._bindNull2353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _prepareForInsert2354;
			public virtual void prepareForInsert() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2354);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2354);
			}
			internal static global::net.sf.jni4net.jni.MethodId _prepareForReplace2355;
			public virtual void prepareForReplace() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2355);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2355);
			}
			internal static global::net.sf.jni4net.jni.MethodId _InsertHelper2356;
			public InsertHelper(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.database.DatabaseUtils.InsertHelper.staticClass, global::android.database.DatabaseUtils.InsertHelper._InsertHelper2356, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			public static int TABLE_INFO_PRAGMA_DEFAULT_INDEX
			{
				get
				{
					return 4;
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.database.DatabaseUtils.InsertHelper.staticClass = @__class;
				global::android.database.DatabaseUtils.InsertHelper._replace2341 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "replace", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._close2342 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "close", "()V");
				global::android.database.DatabaseUtils.InsertHelper._insert2343 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "insert", "(Landroid/content/ContentValues;)J");
				global::android.database.DatabaseUtils.InsertHelper._execute2344 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "execute", "()J");
				global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2345 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
				global::android.database.DatabaseUtils.InsertHelper._bind2346 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IZ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2347 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(I[B)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2348 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IF)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2349 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ILjava/lang/String;)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2350 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IJ)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2351 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(II)V");
				global::android.database.DatabaseUtils.InsertHelper._bind2352 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ID)V");
				global::android.database.DatabaseUtils.InsertHelper._bindNull2353 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bindNull", "(I)V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2354 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForInsert", "()V");
				global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2355 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForReplace", "()V");
				global::android.database.DatabaseUtils.InsertHelper._InsertHelper2356 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeExceptionToParcel2357;
		public static void writeExceptionToParcel(android.os.Parcel arg0, java.lang.Exception arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._writeExceptionToParcel2357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionFromParcel2358;
		public static void readExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionFromParcel2358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionWithFileNotFoundExceptionFromParcel2359;
		public static void readExceptionWithFileNotFoundExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel2359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionWithOperationApplicationExceptionFromParcel2360;
		public static void readExceptionWithOperationApplicationExceptionFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel2360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindObjectToProgram2361;
		public static void bindObjectToProgram(android.database.sqlite.SQLiteProgram arg0, int arg1, java.lang.Object arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._bindObjectToProgram2361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _appendEscapedSQLString2362;
		public static void appendEscapedSQLString(java.lang.StringBuilder arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendEscapedSQLString2362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sqlEscapeString2363;
		public static global::java.lang.String sqlEscapeString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._sqlEscapeString2363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _appendValueToSql2364;
		public static void appendValueToSql(java.lang.StringBuilder arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._appendValueToSql2364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCollationKey2365;
		public static global::java.lang.String getCollationKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getCollationKey2365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHexCollationKey2366;
		public static global::java.lang.String getHexCollationKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._getHexCollationKey2366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2367;
		public static void dumpCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2367, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2368;
		public static void dumpCursor(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2368, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2369;
		public static void dumpCursor(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursor2369, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursorToString2370;
		public static global::java.lang.String dumpCursorToString(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCursorToString2370, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2371;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2372;
		public static void dumpCurrentRow(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2373;
		public static void dumpCurrentRow(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRow2373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRowToString2374;
		public static global::java.lang.String dumpCurrentRowToString(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._dumpCurrentRowToString2374, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToContentValues2375;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues2375, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToContentValues2376;
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToContentValues2376, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToInsertHelper2377;
		public static void cursorStringToInsertHelper(android.database.Cursor arg0, java.lang.String arg1, android.database.DatabaseUtils.InsertHelper arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorStringToInsertHelper2377, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorIntToContentValues2378;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues2378, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorIntToContentValues2379;
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorIntToContentValues2379, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorLongToContentValues2380;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues2380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorLongToContentValues2381;
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorLongToContentValues2381, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorDoubleToCursorValues2382;
		public static void cursorDoubleToCursorValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToCursorValues2382, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorDoubleToContentValues2383;
		public static void cursorDoubleToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorDoubleToContentValues2383, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cursorRowToContentValues2384;
		public static void cursorRowToContentValues(android.database.Cursor arg0, android.content.ContentValues arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._cursorRowToContentValues2384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _queryNumEntries2385;
		public static long queryNumEntries(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._queryNumEntries2385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _longForQuery2386;
		public static long longForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery2386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _longForQuery2387;
		public static long longForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._longForQuery2387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stringForQuery2388;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery2388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stringForQuery2389;
		public static global::java.lang.String stringForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._stringForQuery2389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createDbFromSqlStatements2390;
		public static void createDbFromSqlStatements(android.content.Context arg0, java.lang.String arg1, int arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._createDbFromSqlStatements2390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DatabaseUtils2391;
		public DatabaseUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.DatabaseUtils.staticClass, global::android.database.DatabaseUtils._DatabaseUtils2391, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.DatabaseUtils.staticClass = @__class;
			global::android.database.DatabaseUtils._writeExceptionToParcel2357 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V");
			global::android.database.DatabaseUtils._readExceptionFromParcel2358 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel2359 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel2360 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V");
			global::android.database.DatabaseUtils._bindObjectToProgram2361 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V");
			global::android.database.DatabaseUtils._appendEscapedSQLString2362 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._sqlEscapeString2363 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._appendValueToSql2364 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V");
			global::android.database.DatabaseUtils._getCollationKey2365 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._getHexCollationKey2366 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCursor2367 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCursor2368 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCursor2369 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCursorToString2370 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._dumpCurrentRow2371 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow2372 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;)V");
			global::android.database.DatabaseUtils._dumpCurrentRow2373 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V");
			global::android.database.DatabaseUtils._dumpCurrentRowToString2374 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._cursorStringToContentValues2375 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorStringToContentValues2376 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorStringToInsertHelper2377 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$InsertHelper;I)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues2378 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorIntToContentValues2379 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues2380 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorLongToContentValues2381 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorDoubleToCursorValues2382 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._cursorDoubleToContentValues2383 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V");
			global::android.database.DatabaseUtils._cursorRowToContentValues2384 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V");
			global::android.database.DatabaseUtils._queryNumEntries2385 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery2386 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._longForQuery2387 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J");
			global::android.database.DatabaseUtils._stringForQuery2388 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._stringForQuery2389 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.DatabaseUtils._createDbFromSqlStatements2390 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V");
			global::android.database.DatabaseUtils._DatabaseUtils2391 = @__env.GetMethodID(global::android.database.DatabaseUtils.staticClass, "<init>", "()V");
		}
	}
}
