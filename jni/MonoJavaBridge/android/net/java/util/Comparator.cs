namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Comparator 
	{ 
		bool equals(java.lang.Object arg0); 
		int compare(java.lang.Object arg0, java.lang.Object arg1); 
	} 

	public partial class Comparator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Comparator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Comparator : java.lang.Object, Comparator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Comparator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.__Comparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.__Comparator(@__env); 
			} 
		} 
		internal __Comparator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12809; 
		 bool java.util.Comparator.equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__Comparator)) 
				return @__env.CallBooleanMethod(this, global::java.util.__Comparator._equals12809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__Comparator.staticClass, global::java.util.__Comparator._equals12809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compare12810; 
		 int java.util.Comparator.compare(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__Comparator)) 
				return @__env.CallIntMethod(this, global::java.util.__Comparator._compare12810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__Comparator.staticClass, global::java.util.__Comparator._compare12810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.__Comparator.staticClass = @__class; 
			global::java.util.__Comparator._equals12809 = @__env.GetMethodID(global::java.util.__Comparator.staticClass, "java.util.Comparator.equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.__Comparator._compare12810 = @__env.GetMethodID(global::java.util.__Comparator.staticClass, "java.util.Comparator.compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"); 
		} 
	} 
} 
