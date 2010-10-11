namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteProgram_))]
	public abstract partial class SQLiteProgram : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteProgram()
		{
			InitJNI();
		}
		protected SQLiteProgram(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compile2890;
		protected virtual void compile(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._compile2890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._compile2890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close2891;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._close2891);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._close2891);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased2892;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2892);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2892);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer2893;
		protected override void onAllReferencesReleasedFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2893);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2893);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull2894;
		public virtual void bindNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindNull2894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindNull2894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUniqueId2895;
		public virtual int getUniqueId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._getUniqueId2895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._getUniqueId2895);
		}
		internal static global::MonoJavaBridge.MethodId _bindLong2896;
		public virtual void bindLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindLong2896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindLong2896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble2897;
		public virtual void bindDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindDouble2897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindDouble2897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString2898;
		public virtual void bindString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindString2898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindString2898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindBlob2899;
		public virtual void bindBlob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindBlob2899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindBlob2899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearBindings2900;
		public virtual void clearBindings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._clearBindings2900);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._clearBindings2900);
		}
		internal static global::MonoJavaBridge.MethodId _native_compile2901;
		protected virtual void native_compile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_compile2901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_compile2901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_finalize2902;
		protected virtual void native_finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_finalize2902);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_finalize2902);
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_null2903;
		protected virtual void native_bind_null(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_null2903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_null2903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_long2904;
		protected virtual void native_bind_long(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_long2904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_long2904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_double2905;
		protected virtual void native_bind_double(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_double2905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_double2905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_string2906;
		protected virtual void native_bind_string(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_string2906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_string2906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_blob2907;
		protected virtual void native_bind_blob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_blob2907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_blob2907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
			global::android.database.sqlite.SQLiteProgram._compile2890 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V");
			global::android.database.sqlite.SQLiteProgram._close2891 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2892 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2893 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteProgram._bindNull2894 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteProgram._getUniqueId2895 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I");
			global::android.database.sqlite.SQLiteProgram._bindLong2896 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._bindDouble2897 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._bindString2898 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._bindBlob2899 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V");
			global::android.database.sqlite.SQLiteProgram._clearBindings2900 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V");
			global::android.database.sqlite.SQLiteProgram._native_compile2901 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_finalize2902 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V");
			global::android.database.sqlite.SQLiteProgram._native_bind_null2903 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_long2904 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_double2905 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_string2906 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_blob2907 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteProgram))]
	public sealed partial class SQLiteProgram_ : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteProgram_()
		{
			InitJNI();
		}
		internal SQLiteProgram_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
		}
	}
}
