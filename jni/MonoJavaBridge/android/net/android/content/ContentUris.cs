namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentUris : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentUris() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentUris), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ContentUris(@__env); 
			} 
		} 
		protected ContentUris(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseId1071; 
		public static long parseId(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.content.ContentUris.staticClass, _parseId1071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendId1072; 
		public static android.net.Uri.Builder appendId(android.net.Uri.Builder arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentUris.staticClass, _appendId1072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _withAppendedId1073; 
		public static android.net.Uri withAppendedId(android.net.Uri arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentUris.staticClass, _withAppendedId1073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentUris1074; 
		public ContentUris()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentUris.staticClass, _ContentUris1074, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentUris.staticClass = @__class; 
			global::android.content.ContentUris._parseId1071 = @__env.GetStaticMethodID(global::android.content.ContentUris.staticClass, "parseId", "(Landroid/net/Uri;)J"); 
			global::android.content.ContentUris._appendId1072 = @__env.GetStaticMethodID(global::android.content.ContentUris.staticClass, "appendId", "(Landroid/net/Uri$Builder;J)Landroid/net/Uri$Builder;"); 
			global::android.content.ContentUris._withAppendedId1073 = @__env.GetStaticMethodID(global::android.content.ContentUris.staticClass, "withAppendedId", "(Landroid/net/Uri;J)Landroid/net/Uri;"); 
			global::android.content.ContentUris._ContentUris1074 = @__env.GetMethodID(global::android.content.ContentUris.staticClass, "<init>", "()V"); 
		} 
	} 
} 
