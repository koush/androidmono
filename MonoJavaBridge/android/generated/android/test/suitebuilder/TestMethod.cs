namespace android.test.suitebuilder
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestMethod : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12624;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.suitebuilder.TestMethod.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.suitebuilder.TestMethod._equals12624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12625;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.TestMethod.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.suitebuilder.TestMethod._toString12625) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12626;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.suitebuilder.TestMethod.staticClass, "hashCode", "()I", ref global::android.test.suitebuilder.TestMethod._hashCode12626);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName12627;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.TestMethod.staticClass, "getName", "()Ljava/lang/String;", ref global::android.test.suitebuilder.TestMethod._getName12627) as java.lang.String;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass12628;
		public virtual global::java.lang.Class getEnclosingClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.suitebuilder.TestMethod.staticClass, "getEnclosingClass", "()Ljava/lang/Class;", ref global::android.test.suitebuilder.TestMethod._getEnclosingClass12628) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation12629;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::android.test.suitebuilder.TestMethod.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::android.test.suitebuilder.TestMethod._getAnnotation12629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _createTest12630;
		public virtual global::junit.framework.TestCase createTest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestMethod.staticClass, "createTest", "()Ljunit/framework/TestCase;", ref global::android.test.suitebuilder.TestMethod._createTest12630) as junit.framework.TestCase;
		}
		public new global::java.lang.String EnclosingClassname
		{
			get
			{
				return getEnclosingClassname();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClassname12631;
		public virtual global::java.lang.String getEnclosingClassname()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.TestMethod.staticClass, "getEnclosingClassname", "()Ljava/lang/String;", ref global::android.test.suitebuilder.TestMethod._getEnclosingClassname12631) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod12632;
		public TestMethod(java.lang.String arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.TestMethod._TestMethod12632.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.TestMethod._TestMethod12632 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod12632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod12633;
		public TestMethod(junit.framework.TestCase arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.TestMethod._TestMethod12633.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.TestMethod._TestMethod12633 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljunit/framework/TestCase;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod12633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestMethod12634;
		public TestMethod(java.lang.reflect.Method arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.TestMethod._TestMethod12634.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.TestMethod._TestMethod12634 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestMethod.staticClass, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestMethod.staticClass, global::android.test.suitebuilder.TestMethod._TestMethod12634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TestMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.TestMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
