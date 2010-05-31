namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EventLogTags : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static EventLogTags()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.EventLogTags), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.EventLogTags(@__env);
			}
		}
		protected EventLogTags(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Description : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Description()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.EventLogTags.Description), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.util.EventLogTags.Description(@__env);
				}
			}
			protected Description(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.FieldId _mTag7545;
			public int mTag
			{
				get
				{
					return default(int);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _mName7546;
			public global::java.lang.String mName
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.util.EventLogTags.Description.staticClass = @__class;
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _get7547;
		public virtual global::android.util.EventLogTags.Description get(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.EventLogTags.Description>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.EventLogTags._get7547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.EventLogTags.Description>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get7547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get7548;
		public virtual global::android.util.EventLogTags.Description get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.EventLogTags.Description>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.EventLogTags._get7548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.EventLogTags.Description>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.EventLogTags.staticClass, global::android.util.EventLogTags._get7548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EventLogTags7549;
		public EventLogTags()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags7549, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _EventLogTags7550;
		public EventLogTags(java.io.BufferedReader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.EventLogTags.staticClass, global::android.util.EventLogTags._EventLogTags7550, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.EventLogTags.staticClass = @__class;
			global::android.util.EventLogTags._get7547 = @__env.GetMethodID(global::android.util.EventLogTags.staticClass, "get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._get7548 = @__env.GetMethodID(global::android.util.EventLogTags.staticClass, "get", "(I)Landroid/util/EventLogTags$Description;");
			global::android.util.EventLogTags._EventLogTags7549 = @__env.GetMethodID(global::android.util.EventLogTags.staticClass, "<init>", "()V");
			global::android.util.EventLogTags._EventLogTags7550 = @__env.GetMethodID(global::android.util.EventLogTags.staticClass, "<init>", "(Ljava/io/BufferedReader;)V");
		}
	}
}
