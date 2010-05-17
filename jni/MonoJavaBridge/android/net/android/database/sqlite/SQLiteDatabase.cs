namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteDatabase : android.database.sqlite.SQLiteClosable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteDatabase() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteDatabase(@__env); 
			} 
		} 
		protected SQLiteDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface CursorFactory 
		{ 
			android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replace2272; 
		public virtual long replace(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _replace2272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _replace2272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2273; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _close2273); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _close2273); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete2274; 
		public virtual int delete(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallIntMethod(this, _delete2274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _delete2274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert2275; 
		public virtual long insert(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _insert2275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _insert2275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly2276; 
		public virtual bool isReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _isReadOnly2276); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _isReadOnly2276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath2277; 
		public virtual java.lang.String getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPath2277)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _getPath2277)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen2278; 
		public virtual bool isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _isOpen2278); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _isOpen2278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query2279; 
		public virtual android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query2279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _query2279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query2280; 
		public virtual android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query2280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _query2280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query2281; 
		public virtual android.database.Cursor query(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query2281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _query2281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create2282; 
		public static android.database.sqlite.SQLiteDatabase create(android.database.sqlite.SQLiteDatabase.CursorFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, _create2282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update2283; 
		public virtual int update(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallIntMethod(this, _update2283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _update2283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVersion2284; 
		public virtual int getVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallIntMethod(this, _getVersion2284); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _getVersion2284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVersion2285; 
		public virtual void setVersion(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _setVersion2285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setVersion2285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocale2286; 
		public virtual void setLocale(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _setLocale2286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setLocale2286, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase2287; 
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, _openOrCreateDatabase2287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase2288; 
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, _openOrCreateDatabase2288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2289; 
		protected override void onAllReferencesReleased() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleased2289); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _onAllReferencesReleased2289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _releaseMemory2290; 
		public static int releaseMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.database.sqlite.SQLiteDatabase.staticClass, _releaseMemory2290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLockingEnabled2291; 
		public virtual void setLockingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _setLockingEnabled2291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setLockingEnabled2291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginTransaction2292; 
		public virtual void beginTransaction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _beginTransaction2292); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _beginTransaction2292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginTransactionWithListener2293; 
		public virtual void beginTransactionWithListener(android.database.sqlite.SQLiteTransactionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _beginTransactionWithListener2293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _beginTransactionWithListener2293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endTransaction2294; 
		public virtual void endTransaction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _endTransaction2294); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _endTransaction2294); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTransactionSuccessful2295; 
		public virtual void setTransactionSuccessful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _setTransactionSuccessful2295); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setTransactionSuccessful2295); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inTransaction2296; 
		public virtual bool inTransaction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _inTransaction2296); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _inTransaction2296); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDbLockedByCurrentThread2297; 
		public virtual bool isDbLockedByCurrentThread() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _isDbLockedByCurrentThread2297); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _isDbLockedByCurrentThread2297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDbLockedByOtherThreads2298; 
		public virtual bool isDbLockedByOtherThreads() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _isDbLockedByOtherThreads2298); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _isDbLockedByOtherThreads2298); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContended2299; 
		public virtual bool yieldIfContended() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _yieldIfContended2299); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _yieldIfContended2299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContendedSafely2300; 
		public virtual bool yieldIfContendedSafely() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _yieldIfContendedSafely2300); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _yieldIfContendedSafely2300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContendedSafely2301; 
		public virtual bool yieldIfContendedSafely(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _yieldIfContendedSafely2301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _yieldIfContendedSafely2301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSyncedTables2302; 
		public virtual java.util.Map getSyncedTables() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getSyncedTables2302)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _getSyncedTables2302)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openDatabase2303; 
		public static android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, _openDatabase2303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumSize2304; 
		public virtual long getMaximumSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _getMaximumSize2304); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _getMaximumSize2304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumSize2305; 
		public virtual long setMaximumSize(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _setMaximumSize2305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setMaximumSize2305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPageSize2306; 
		public virtual long getPageSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _getPageSize2306); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _getPageSize2306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPageSize2307; 
		public virtual void setPageSize(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _setPageSize2307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _setPageSize2307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markTableSyncable2308; 
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _markTableSyncable2308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _markTableSyncable2308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markTableSyncable2309; 
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _markTableSyncable2309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _markTableSyncable2309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findEditTable2310; 
		public static java.lang.String findEditTable(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, _findEditTable2310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compileStatement2311; 
		public virtual android.database.sqlite.SQLiteStatement compileStatement(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteStatement>(@__env, @__env.CallObjectMethodPtr(this, _compileStatement2311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteStatement>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _compileStatement2311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queryWithFactory2312; 
		public virtual android.database.Cursor queryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _queryWithFactory2312, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _queryWithFactory2312, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rawQuery2313; 
		public virtual android.database.Cursor rawQuery(java.lang.String arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _rawQuery2313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _rawQuery2313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rawQueryWithFactory2314; 
		public virtual android.database.Cursor rawQueryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _rawQueryWithFactory2314, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteDatabase.staticClass, _rawQueryWithFactory2314, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insertOrThrow2315; 
		public virtual long insertOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _insertOrThrow2315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _insertOrThrow2315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrThrow2316; 
		public virtual long replaceOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallLongMethod(this, _replaceOrThrow2316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _replaceOrThrow2316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _execSQL2317; 
		public virtual void execSQL(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _execSQL2317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _execSQL2317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _execSQL2318; 
		public virtual void execSQL(java.lang.String arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				@__env.CallVoidMethod(this, _execSQL2318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _execSQL2318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _needUpgrade2319; 
		public virtual bool needUpgrade(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteDatabase)) 
				return @__env.CallBooleanMethod(this, _needUpgrade2319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.sqlite.SQLiteDatabase.staticClass, _needUpgrade2319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		public static int SQLITE_MAX_LIKE_PATTERN_LENGTH
		{ 
			get 
			{ 
				return 50000; 
			} 
		} 
		public static int OPEN_READWRITE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int OPEN_READONLY
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int NO_LOCALIZED_COLLATORS
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int CREATE_IF_NECESSARY
		{ 
			get 
			{ 
				return 268435456; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteDatabase.staticClass = @__class; 
			global::android.database.sqlite.SQLiteDatabase._replace2272 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J"); 
			global::android.database.sqlite.SQLiteDatabase._close2273 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "close", "()V"); 
			global::android.database.sqlite.SQLiteDatabase._delete2274 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.database.sqlite.SQLiteDatabase._insert2275 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J"); 
			global::android.database.sqlite.SQLiteDatabase._isReadOnly2276 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isReadOnly", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._getPath2277 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::android.database.sqlite.SQLiteDatabase._isOpen2278 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isOpen", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._query2279 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._query2280 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._query2281 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._create2282 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteDatabase._update2283 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.database.sqlite.SQLiteDatabase._getVersion2284 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getVersion", "()I"); 
			global::android.database.sqlite.SQLiteDatabase._setVersion2285 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setVersion", "(I)V"); 
			global::android.database.sqlite.SQLiteDatabase._setLocale2286 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLocale", "(Ljava/util/Locale;)V"); 
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2287 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2288 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2289 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "onAllReferencesReleased", "()V"); 
			global::android.database.sqlite.SQLiteDatabase._releaseMemory2290 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "releaseMemory", "()I"); 
			global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2291 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLockingEnabled", "(Z)V"); 
			global::android.database.sqlite.SQLiteDatabase._beginTransaction2292 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransaction", "()V"); 
			global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2293 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V"); 
			global::android.database.sqlite.SQLiteDatabase._endTransaction2294 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "endTransaction", "()V"); 
			global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2295 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setTransactionSuccessful", "()V"); 
			global::android.database.sqlite.SQLiteDatabase._inTransaction2296 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "inTransaction", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2297 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByCurrentThread", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2298 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByOtherThreads", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._yieldIfContended2299 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContended", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2300 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "()Z"); 
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2301 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "(J)Z"); 
			global::android.database.sqlite.SQLiteDatabase._getSyncedTables2302 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getSyncedTables", "()Ljava/util/Map;"); 
			global::android.database.sqlite.SQLiteDatabase._openDatabase2303 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteDatabase._getMaximumSize2304 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getMaximumSize", "()J"); 
			global::android.database.sqlite.SQLiteDatabase._setMaximumSize2305 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setMaximumSize", "(J)J"); 
			global::android.database.sqlite.SQLiteDatabase._getPageSize2306 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPageSize", "()J"); 
			global::android.database.sqlite.SQLiteDatabase._setPageSize2307 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setPageSize", "(J)V"); 
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2308 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2309 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteDatabase._findEditTable2310 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "findEditTable", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.database.sqlite.SQLiteDatabase._compileStatement2311 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;"); 
			global::android.database.sqlite.SQLiteDatabase._queryWithFactory2312 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._rawQuery2313 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2314 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.SQLiteDatabase._insertOrThrow2315 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J"); 
			global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2316 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J"); 
			global::android.database.sqlite.SQLiteDatabase._execSQL2317 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteDatabase._execSQL2318 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V"); 
			global::android.database.sqlite.SQLiteDatabase._needUpgrade2319 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "needUpgrade", "(I)Z"); 
		} 
	} 
} 
