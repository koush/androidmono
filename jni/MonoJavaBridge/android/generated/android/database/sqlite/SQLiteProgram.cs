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
		internal static global::MonoJavaBridge.MethodId _compile4800;
		protected virtual void compile(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._compile4800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._compile4800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close4801;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._close4801);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._close4801);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4802;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4802);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4802);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer4803;
		protected override void onAllReferencesReleasedFromContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4803);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4803);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull4804;
		public virtual void bindNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindNull4804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindNull4804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUniqueId4805;
		public virtual int getUniqueId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._getUniqueId4805);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._getUniqueId4805);
		}
		internal static global::MonoJavaBridge.MethodId _bindLong4806;
		public virtual void bindLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindLong4806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindLong4806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble4807;
		public virtual void bindDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindDouble4807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindDouble4807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString4808;
		public virtual void bindString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindString4808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindString4808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindBlob4809;
		public virtual void bindBlob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindBlob4809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindBlob4809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearBindings4810;
		public virtual void clearBindings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._clearBindings4810);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._clearBindings4810);
		}
		internal static global::MonoJavaBridge.MethodId _native_compile4811;
		protected virtual void native_compile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_compile4811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_compile4811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_finalize4812;
		protected virtual void native_finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_finalize4812);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_finalize4812);
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_null4813;
		protected virtual void native_bind_null(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_null4813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_null4813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_long4814;
		protected virtual void native_bind_long(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_long4814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_long4814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_double4815;
		protected virtual void native_bind_double(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_double4815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_double4815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_string4816;
		protected virtual void native_bind_string(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_string4816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_string4816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_blob4817;
		protected virtual void native_bind_blob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_blob4817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_blob4817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
			global::android.database.sqlite.SQLiteProgram._compile4800 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V");
			global::android.database.sqlite.SQLiteProgram._close4801 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4802 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4803 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteProgram._bindNull4804 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteProgram._getUniqueId4805 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I");
			global::android.database.sqlite.SQLiteProgram._bindLong4806 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._bindDouble4807 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._bindString4808 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._bindBlob4809 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V");
			global::android.database.sqlite.SQLiteProgram._clearBindings4810 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V");
			global::android.database.sqlite.SQLiteProgram._native_compile4811 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_finalize4812 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V");
			global::android.database.sqlite.SQLiteProgram._native_bind_null4813 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_long4814 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_double4815 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_string4816 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_blob4817 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V");
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
