namespace android.test.suitebuilder
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestMethod : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestMethod()
		{
			InitJNI();
		}
		protected TestMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals8088;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._equals8088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._equals8088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString8089;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._toString8089)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._toString8089)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode8090;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._hashCode8090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._hashCode8090);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName8091;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._getName8091)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._getName8091)) as java.lang.String;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass8092;
		public virtual global::java.lang.Class getEnclosingClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._getEnclosingClass8092)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._getEnclosingClass8092)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation8093;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._getAnnotation8093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._getAnnotation8093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _createTest8094;
		public virtual global::junit.framework.TestCase createTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._createTest8094)) as junit.framework.TestCase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._createTest8094)) as junit.framework.TestCase;
		}
		public new global::java.lang.String EnclosingClassname
		{
			get
			{
				return getEnclosingClassname();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClassname8095;
		public virtual global::java.lang.String getEnclosingClassname() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod._getEnclosingClassname8095)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._getEnclosingClassname8095)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod8096;
		public TestMethod(java.lang.String arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod8096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod8097;
		public TestMethod(junit.framework.TestCase arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod8097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod8098;
		public TestMethod(java.lang.reflect.Method arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod8098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.TestMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestMethod"));
			global::android.test.suitebuilder.TestMethod._equals8088 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.TestMethod._toString8089 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.TestMethod._hashCode8090 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.TestMethod._getName8091 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "getName", "()Ljava/lang/String;");
			global::android.test.suitebuilder.TestMethod._getEnclosingClass8092 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "getEnclosingClass", "()Ljava/lang/Class;");
			global::android.test.suitebuilder.TestMethod._getAnnotation8093 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::android.test.suitebuilder.TestMethod._createTest8094 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "createTest", "()Ljunit/framework/TestCase;");
			global::android.test.suitebuilder.TestMethod._getEnclosingClassname8095 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "getEnclosingClassname", "()Ljava/lang/String;");
			global::android.test.suitebuilder.TestMethod._TestMethod8096 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::android.test.suitebuilder.TestMethod._TestMethod8097 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljunit/framework/TestCase;)V");
			global::android.test.suitebuilder.TestMethod._TestMethod8098 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)V");
		}
	}
}
