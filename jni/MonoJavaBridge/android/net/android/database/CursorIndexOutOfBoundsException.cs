namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CursorIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{ 
		internal static global::java.lang.Class staticClass; 
		static CursorIndexOutOfBoundsException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorIndexOutOfBoundsException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.CursorIndexOutOfBoundsException(@__env); 
			} 
		} 
		protected CursorIndexOutOfBoundsException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorIndexOutOfBoundsException2252; 
		public CursorIndexOutOfBoundsException(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException2252, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorIndexOutOfBoundsException2253; 
		public CursorIndexOutOfBoundsException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException2253, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.CursorIndexOutOfBoundsException.staticClass = @__class; 
			global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException2252 = @__env.GetMethodID(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(II)V"); 
			global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException2253 = @__env.GetMethodID(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
