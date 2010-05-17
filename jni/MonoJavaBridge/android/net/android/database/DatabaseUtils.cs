namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatabaseUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatabaseUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.DatabaseUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.DatabaseUtils.InsertHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _replace2157; 
			public virtual long replace(android.content.ContentValues arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					return @__env.CallLongMethod(this, _replace2157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _replace2157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _close2158; 
			public virtual void close() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _close2158); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _close2158); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _insert2159; 
			public virtual long insert(android.content.ContentValues arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					return @__env.CallLongMethod(this, _insert2159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _insert2159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _execute2160; 
			public virtual long execute() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					return @__env.CallLongMethod(this, _execute2160); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _execute2160); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2161; 
			public virtual int getColumnIndex(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					return @__env.CallIntMethod(this, _getColumnIndex2161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _getColumnIndex2161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2162; 
			public virtual void bind(int arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2163; 
			public virtual void bind(int arg0, byte[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2164; 
			public virtual void bind(int arg0, float arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2165; 
			public virtual void bind(int arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2166; 
			public virtual void bind(int arg0, long arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2167; 
			public virtual void bind(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bind2168; 
			public virtual void bind(int arg0, double arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bind2168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bind2168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bindNull2169; 
			public virtual void bindNull(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _bindNull2169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _bindNull2169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _prepareForInsert2170; 
			public virtual void prepareForInsert() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _prepareForInsert2170); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _prepareForInsert2170); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _prepareForReplace2171; 
			public virtual void prepareForReplace() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.DatabaseUtils.InsertHelper)) 
					@__env.CallVoidMethod(this, _prepareForReplace2171); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.DatabaseUtils.InsertHelper.staticClass, _prepareForReplace2171); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InsertHelper2172; 
			public InsertHelper(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.database.DatabaseUtils.InsertHelper.staticClass, _InsertHelper2172, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
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
				global::android.database.DatabaseUtils.InsertHelper._replace2157 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "replace", "(Landroid/content/ContentValues;)J"); 
				global::android.database.DatabaseUtils.InsertHelper._close2158 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "close", "()V"); 
				global::android.database.DatabaseUtils.InsertHelper._insert2159 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "insert", "(Landroid/content/ContentValues;)J"); 
				global::android.database.DatabaseUtils.InsertHelper._execute2160 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "execute", "()J"); 
				global::android.database.DatabaseUtils.InsertHelper._getColumnIndex2161 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2162 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IZ)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2163 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(I[B)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2164 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IF)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2165 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ILjava/lang/String;)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2166 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(IJ)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2167 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(II)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bind2168 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bind", "(ID)V"); 
				global::android.database.DatabaseUtils.InsertHelper._bindNull2169 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "bindNull", "(I)V"); 
				global::android.database.DatabaseUtils.InsertHelper._prepareForInsert2170 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForInsert", "()V"); 
				global::android.database.DatabaseUtils.InsertHelper._prepareForReplace2171 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "prepareForReplace", "()V"); 
				global::android.database.DatabaseUtils.InsertHelper._InsertHelper2172 = @__env.GetMethodID(global::android.database.DatabaseUtils.InsertHelper.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeExceptionToParcel2173; 
		public static void writeExceptionToParcel(android.os.Parcel arg0, java.lang.Exception arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _writeExceptionToParcel2173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionFromParcel2174; 
		public static void readExceptionFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _readExceptionFromParcel2174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionWithFileNotFoundExceptionFromParcel2175; 
		public static void readExceptionWithFileNotFoundExceptionFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _readExceptionWithFileNotFoundExceptionFromParcel2175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readExceptionWithOperationApplicationExceptionFromParcel2176; 
		public static void readExceptionWithOperationApplicationExceptionFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _readExceptionWithOperationApplicationExceptionFromParcel2176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindObjectToProgram2177; 
		public static void bindObjectToProgram(android.database.sqlite.SQLiteProgram arg0, int arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _bindObjectToProgram2177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendEscapedSQLString2178; 
		public static void appendEscapedSQLString(java.lang.StringBuilder arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _appendEscapedSQLString2178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sqlEscapeString2179; 
		public static java.lang.String sqlEscapeString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _sqlEscapeString2179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendValueToSql2180; 
		public static void appendValueToSql(java.lang.StringBuilder arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _appendValueToSql2180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCollationKey2181; 
		public static java.lang.String getCollationKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _getCollationKey2181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHexCollationKey2182; 
		public static java.lang.String getHexCollationKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _getHexCollationKey2182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2183; 
		public static void dumpCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCursor2183, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2184; 
		public static void dumpCursor(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCursor2184, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursor2185; 
		public static void dumpCursor(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCursor2185, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCursorToString2186; 
		public static java.lang.String dumpCursorToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _dumpCursorToString2186, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2187; 
		public static void dumpCurrentRow(android.database.Cursor arg0, java.lang.StringBuilder arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCurrentRow2187, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2188; 
		public static void dumpCurrentRow(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCurrentRow2188, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRow2189; 
		public static void dumpCurrentRow(android.database.Cursor arg0, java.io.PrintStream arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _dumpCurrentRow2189, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpCurrentRowToString2190; 
		public static java.lang.String dumpCurrentRowToString(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _dumpCurrentRowToString2190, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToContentValues2191; 
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorStringToContentValues2191, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToContentValues2192; 
		public static void cursorStringToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorStringToContentValues2192, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorStringToInsertHelper2193; 
		public static void cursorStringToInsertHelper(android.database.Cursor arg0, java.lang.String arg1, android.database.DatabaseUtils.InsertHelper arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorStringToInsertHelper2193, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorIntToContentValues2194; 
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorIntToContentValues2194, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorIntToContentValues2195; 
		public static void cursorIntToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorIntToContentValues2195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorLongToContentValues2196; 
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorLongToContentValues2196, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorLongToContentValues2197; 
		public static void cursorLongToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorLongToContentValues2197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorDoubleToCursorValues2198; 
		public static void cursorDoubleToCursorValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorDoubleToCursorValues2198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorDoubleToContentValues2199; 
		public static void cursorDoubleToContentValues(android.database.Cursor arg0, java.lang.String arg1, android.content.ContentValues arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorDoubleToContentValues2199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorRowToContentValues2200; 
		public static void cursorRowToContentValues(android.database.Cursor arg0, android.content.ContentValues arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _cursorRowToContentValues2200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queryNumEntries2201; 
		public static long queryNumEntries(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, _queryNumEntries2201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _longForQuery2202; 
		public static long longForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, _longForQuery2202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _longForQuery2203; 
		public static long longForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.database.DatabaseUtils.staticClass, _longForQuery2203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stringForQuery2204; 
		public static java.lang.String stringForQuery(android.database.sqlite.SQLiteDatabase arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _stringForQuery2204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stringForQuery2205; 
		public static java.lang.String stringForQuery(android.database.sqlite.SQLiteStatement arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.DatabaseUtils.staticClass, _stringForQuery2205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createDbFromSqlStatements2206; 
		public static void createDbFromSqlStatements(android.content.Context arg0, java.lang.String arg1, int arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.database.DatabaseUtils.staticClass, _createDbFromSqlStatements2206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatabaseUtils2207; 
		public DatabaseUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.DatabaseUtils.staticClass, _DatabaseUtils2207, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.DatabaseUtils.staticClass = @__class; 
			global::android.database.DatabaseUtils._writeExceptionToParcel2173 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V"); 
			global::android.database.DatabaseUtils._readExceptionFromParcel2174 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.database.DatabaseUtils._readExceptionWithFileNotFoundExceptionFromParcel2175 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.database.DatabaseUtils._readExceptionWithOperationApplicationExceptionFromParcel2176 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.database.DatabaseUtils._bindObjectToProgram2177 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V"); 
			global::android.database.DatabaseUtils._appendEscapedSQLString2178 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V"); 
			global::android.database.DatabaseUtils._sqlEscapeString2179 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._appendValueToSql2180 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V"); 
			global::android.database.DatabaseUtils._getCollationKey2181 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._getHexCollationKey2182 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._dumpCursor2183 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;)V"); 
			global::android.database.DatabaseUtils._dumpCursor2184 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V"); 
			global::android.database.DatabaseUtils._dumpCursor2185 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V"); 
			global::android.database.DatabaseUtils._dumpCursorToString2186 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._dumpCurrentRow2187 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V"); 
			global::android.database.DatabaseUtils._dumpCurrentRow2188 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;)V"); 
			global::android.database.DatabaseUtils._dumpCurrentRow2189 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V"); 
			global::android.database.DatabaseUtils._dumpCurrentRowToString2190 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._cursorStringToContentValues2191 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V"); 
			global::android.database.DatabaseUtils._cursorStringToContentValues2192 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V"); 
			global::android.database.DatabaseUtils._cursorStringToInsertHelper2193 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$InsertHelper;I)V"); 
			global::android.database.DatabaseUtils._cursorIntToContentValues2194 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V"); 
			global::android.database.DatabaseUtils._cursorIntToContentValues2195 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V"); 
			global::android.database.DatabaseUtils._cursorLongToContentValues2196 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V"); 
			global::android.database.DatabaseUtils._cursorLongToContentValues2197 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V"); 
			global::android.database.DatabaseUtils._cursorDoubleToCursorValues2198 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V"); 
			global::android.database.DatabaseUtils._cursorDoubleToContentValues2199 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;)V"); 
			global::android.database.DatabaseUtils._cursorRowToContentValues2200 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V"); 
			global::android.database.DatabaseUtils._queryNumEntries2201 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J"); 
			global::android.database.DatabaseUtils._longForQuery2202 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J"); 
			global::android.database.DatabaseUtils._longForQuery2203 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J"); 
			global::android.database.DatabaseUtils._stringForQuery2204 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._stringForQuery2205 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.DatabaseUtils._createDbFromSqlStatements2206 = @__env.GetStaticMethodID(global::android.database.DatabaseUtils.staticClass, "createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V"); 
			global::android.database.DatabaseUtils._DatabaseUtils2207 = @__env.GetMethodID(global::android.database.DatabaseUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
