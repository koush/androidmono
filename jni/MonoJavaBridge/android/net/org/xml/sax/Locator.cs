namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Locator 
	{ 
		int getLineNumber(); 
		java.lang.String getPublicId(); 
		java.lang.String getSystemId(); 
		int getColumnNumber(); 
	} 

	public partial class Locator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Locator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Locator : java.lang.Object, Locator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Locator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xml.sax.__Locator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.__Locator(@__env); 
			} 
		} 
		internal __Locator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber13320; 
		 int org.xml.sax.Locator.getLineNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__Locator)) 
				return @__env.CallIntMethod(this, _getLineNumber13320); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xml.sax.__Locator.staticClass, _getLineNumber13320); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId13321; 
		 java.lang.String org.xml.sax.Locator.getPublicId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__Locator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPublicId13321)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.__Locator.staticClass, _getPublicId13321)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId13322; 
		 java.lang.String org.xml.sax.Locator.getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__Locator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSystemId13322)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.__Locator.staticClass, _getSystemId13322)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber13323; 
		 int org.xml.sax.Locator.getColumnNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__Locator)) 
				return @__env.CallIntMethod(this, _getColumnNumber13323); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xml.sax.__Locator.staticClass, _getColumnNumber13323); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.__Locator.staticClass = @__class; 
			global::org.xml.sax.__Locator._getLineNumber13320 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getLineNumber", "()I"); 
			global::org.xml.sax.__Locator._getPublicId13321 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getPublicId", "()Ljava/lang/String;"); 
			global::org.xml.sax.__Locator._getSystemId13322 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getSystemId", "()Ljava/lang/String;"); 
			global::org.xml.sax.__Locator._getColumnNumber13323 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getColumnNumber", "()I"); 
		} 
	} 
} 
