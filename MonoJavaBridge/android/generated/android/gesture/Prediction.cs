namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Prediction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Prediction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString5006;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.Prediction._toString5006.native == global::System.IntPtr.Zero)
				global::android.gesture.Prediction._toString5006 = @__env.GetMethodIDNoThrow(global::android.gesture.Prediction.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.gesture.Prediction.staticClass, global::android.gesture.Prediction._toString5006) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _name5007;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name5007)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _score5008;
		public double score
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _score5008);
			}
			set
			{
			}
		}
		static Prediction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Prediction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Prediction"));
			global::android.gesture.Prediction._name5007 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "name", "Ljava/lang/String;");
			global::android.gesture.Prediction._score5008 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "score", "D");
		}
		internal static void InitJNI()
		{
		}
	}
}
