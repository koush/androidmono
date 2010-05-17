namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SQLiteProgram : android.database.sqlite.SQLiteClosable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteProgram() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteProgram), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SQLiteProgram(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compile2339; 
		protected virtual void compile(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _compile2339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _compile2339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2340; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _close2340); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _close2340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2341; 
		protected override void onAllReferencesReleased() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleased2341); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _onAllReferencesReleased2341); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleasedFromContainer2342; 
		protected override void onAllReferencesReleasedFromContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleasedFromContainer2342); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _onAllReferencesReleasedFromContainer2342); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindNull2343; 
		public virtual void bindNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _bindNull2343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _bindNull2343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUniqueId2344; 
		public virtual int getUniqueId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				return @__env.CallIntMethod(this, _getUniqueId2344); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _getUniqueId2344); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindLong2345; 
		public virtual void bindLong(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _bindLong2345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _bindLong2345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindDouble2346; 
		public virtual void bindDouble(int arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _bindDouble2346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _bindDouble2346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindString2347; 
		public virtual void bindString(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _bindString2347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _bindString2347, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindBlob2348; 
		public virtual void bindBlob(int arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _bindBlob2348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _bindBlob2348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearBindings2349; 
		public virtual void clearBindings() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _clearBindings2349); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _clearBindings2349); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_compile2350; 
		protected virtual void native_compile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_compile2350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_compile2350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_finalize2351; 
		protected virtual void native_finalize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_finalize2351); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_finalize2351); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_null2352; 
		protected virtual void native_bind_null(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_bind_null2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_bind_null2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_long2353; 
		protected virtual void native_bind_long(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_bind_long2353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_bind_long2353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_double2354; 
		protected virtual void native_bind_double(int arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_bind_double2354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_bind_double2354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_string2355; 
		protected virtual void native_bind_string(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_bind_string2355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_bind_string2355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_blob2356; 
		protected virtual void native_bind_blob(int arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteProgram)) 
				@__env.CallVoidMethod(this, _native_bind_blob2356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteProgram.staticClass, _native_bind_blob2356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteProgram.staticClass = @__class; 
			global::android.database.sqlite.SQLiteProgram._compile2339 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V"); 
			global::android.database.sqlite.SQLiteProgram._close2340 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V"); 
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2341 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V"); 
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2342 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V"); 
			global::android.database.sqlite.SQLiteProgram._bindNull2343 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V"); 
			global::android.database.sqlite.SQLiteProgram._getUniqueId2344 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I"); 
			global::android.database.sqlite.SQLiteProgram._bindLong2345 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V"); 
			global::android.database.sqlite.SQLiteProgram._bindDouble2346 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V"); 
			global::android.database.sqlite.SQLiteProgram._bindString2347 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteProgram._bindBlob2348 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V"); 
			global::android.database.sqlite.SQLiteProgram._clearBindings2349 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V"); 
			global::android.database.sqlite.SQLiteProgram._native_compile2350 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteProgram._native_finalize2351 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V"); 
			global::android.database.sqlite.SQLiteProgram._native_bind_null2352 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V"); 
			global::android.database.sqlite.SQLiteProgram._native_bind_long2353 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V"); 
			global::android.database.sqlite.SQLiteProgram._native_bind_double2354 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V"); 
			global::android.database.sqlite.SQLiteProgram._native_bind_string2355 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V"); 
			global::android.database.sqlite.SQLiteProgram._native_bind_blob2356 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V"); 
		} 
	} 
} 
