namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class UriMatcher : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static UriMatcher()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.UriMatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.UriMatcher(@__env);
			}
		}
		protected UriMatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _match1565;
		public virtual int match(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.UriMatcher._match1565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._match1565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addURI1566;
		public virtual void addURI(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.UriMatcher._addURI1566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._addURI1566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _UriMatcher1567;
		public UriMatcher(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.UriMatcher.staticClass, global::android.content.UriMatcher._UriMatcher1567, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		public static int NO_MATCH
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.UriMatcher.staticClass = @__class;
			global::android.content.UriMatcher._match1565 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "match", "(Landroid/net/Uri;)I");
			global::android.content.UriMatcher._addURI1566 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "addURI", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::android.content.UriMatcher._UriMatcher1567 = @__env.GetMethodID(global::android.content.UriMatcher.staticClass, "<init>", "(I)V");
		}
	}
}
