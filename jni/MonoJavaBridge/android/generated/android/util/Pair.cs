namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Pair : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Pair()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Pair), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Pair(@__env);
			}
		}
		protected Pair(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals8253;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.Pair._equals8253, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.Pair.staticClass, global::android.util.Pair._equals8253, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode8254;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.Pair._hashCode8254);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.Pair.staticClass, global::android.util.Pair._hashCode8254);
		}
		internal static global::net.sf.jni4net.jni.MethodId _create8255;
		public static global::android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Pair>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Pair.staticClass, global::android.util.Pair._create8255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Pair8256;
		public Pair(java.lang.Object arg0, java.lang.Object arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.Pair.staticClass, global::android.util.Pair._Pair8256, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _first8257;
		public global::java.lang.Object first
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _second8258;
		public global::java.lang.Object second
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Pair.staticClass = @__class;
			global::android.util.Pair._equals8253 = @__env.GetMethodID(global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.util.Pair._hashCode8254 = @__env.GetMethodID(global::android.util.Pair.staticClass, "hashCode", "()I");
			global::android.util.Pair._create8255 = @__env.GetStaticMethodID(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;");
			global::android.util.Pair._Pair8256 = @__env.GetMethodID(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
		}
	}
}
