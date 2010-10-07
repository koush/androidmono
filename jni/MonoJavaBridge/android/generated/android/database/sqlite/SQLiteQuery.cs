namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteQuery : android.database.sqlite.SQLiteProgram
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteQuery()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteQuery), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteQuery(@__env);
			}
		}
		protected SQLiteQuery(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString2736;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteQuery._toString2736));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._toString2736));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2737;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery._close2737);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._close2737);
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindNull2738;
		public override void bindNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery._bindNull2738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindNull2738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindLong2739;
		public override void bindLong(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery._bindLong2739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindLong2739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindDouble2740;
		public override void bindDouble(int arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery._bindDouble2740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindDouble2740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindString2741;
		public override void bindString(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteQuery._bindString2741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteQuery.staticClass, global::android.database.sqlite.SQLiteQuery._bindString2741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteQuery.staticClass = @__class;
			global::android.database.sqlite.SQLiteQuery._toString2736 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "toString", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQuery._close2737 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteQuery._bindNull2738 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteQuery._bindLong2739 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteQuery._bindDouble2740 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteQuery._bindString2741 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindString", "(ILjava/lang/String;)V");
		}
	}
}
