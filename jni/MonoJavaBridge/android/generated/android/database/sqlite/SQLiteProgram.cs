namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SQLiteProgram : android.database.sqlite.SQLiteClosable
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteProgram()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteProgram), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SQLiteProgram(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _compile2718;
		protected virtual void compile(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._compile2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._compile2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2719;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._close2719);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._close2719);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2720;
		protected override void onAllReferencesReleased() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2720);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2720);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleasedFromContainer2721;
		protected override void onAllReferencesReleasedFromContainer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2721);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2721);
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindNull2722;
		public virtual void bindNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._bindNull2722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindNull2722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUniqueId2723;
		public virtual int getUniqueId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteProgram._getUniqueId2723);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._getUniqueId2723);
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindLong2724;
		public virtual void bindLong(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._bindLong2724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindLong2724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindDouble2725;
		public virtual void bindDouble(int arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._bindDouble2725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindDouble2725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindString2726;
		public virtual void bindString(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._bindString2726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindString2726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindBlob2727;
		public virtual void bindBlob(int arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._bindBlob2727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindBlob2727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearBindings2728;
		public virtual void clearBindings() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._clearBindings2728);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._clearBindings2728);
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_compile2729;
		protected virtual void native_compile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_compile2729, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_compile2729, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_finalize2730;
		protected virtual void native_finalize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_finalize2730);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_finalize2730);
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_null2731;
		protected virtual void native_bind_null(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_bind_null2731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_null2731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_long2732;
		protected virtual void native_bind_long(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_bind_long2732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_long2732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_double2733;
		protected virtual void native_bind_double(int arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_bind_double2733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_double2733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_string2734;
		protected virtual void native_bind_string(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_bind_string2734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_string2734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _native_bind_blob2735;
		protected virtual void native_bind_blob(int arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteProgram._native_bind_blob2735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_blob2735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteProgram.staticClass = @__class;
			global::android.database.sqlite.SQLiteProgram._compile2718 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V");
			global::android.database.sqlite.SQLiteProgram._close2719 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased2720 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer2721 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteProgram._bindNull2722 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteProgram._getUniqueId2723 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I");
			global::android.database.sqlite.SQLiteProgram._bindLong2724 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._bindDouble2725 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._bindString2726 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._bindBlob2727 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V");
			global::android.database.sqlite.SQLiteProgram._clearBindings2728 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V");
			global::android.database.sqlite.SQLiteProgram._native_compile2729 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_finalize2730 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V");
			global::android.database.sqlite.SQLiteProgram._native_bind_null2731 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_long2732 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_double2733 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_string2734 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_blob2735 = @__env.GetMethodID(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V");
		}
	}
}
