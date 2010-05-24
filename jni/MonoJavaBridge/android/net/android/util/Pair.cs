namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Pair : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Pair() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.Pair), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7587; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.Pair)) 
				return @__env.CallIntMethod(this, _hashCode7587); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.Pair.staticClass, _hashCode7587); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals7588; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.Pair)) 
				return @__env.CallBooleanMethod(this, _equals7588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.util.Pair.staticClass, _equals7588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create7589; 
		public static android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Pair>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Pair.staticClass, _create7589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Pair7590; 
		public Pair(java.lang.Object arg0, java.lang.Object arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.Pair.staticClass, _Pair7590, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _first7591; 
		public java.lang.Object first
		{ 
			get 
			{ 
				return default(java.lang.Object); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _second7592; 
		public java.lang.Object second
		{ 
			get 
			{ 
				return default(java.lang.Object); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.Pair.staticClass = @__class; 
			global::android.util.Pair._hashCode7587 = @__env.GetMethodID(global::android.util.Pair.staticClass, "hashCode", "()I"); 
			global::android.util.Pair._equals7588 = @__env.GetMethodID(global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.util.Pair._create7589 = @__env.GetStaticMethodID(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;"); 
			global::android.util.Pair._Pair7590 = @__env.GetMethodID(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V"); 
		} 
	} 
} 
