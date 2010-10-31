namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Prediction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Prediction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.gesture.Prediction.staticClass, "toString", "()Ljava/lang/String;", ref global::android.gesture.Prediction._m0) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _name2233;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name2233)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _score2234;
		public double score
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _score2234);
			}
			set
			{
			}
		}
		static Prediction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Prediction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Prediction"));
			global::android.gesture.Prediction._name2233 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "name", "Ljava/lang/String;");
			global::android.gesture.Prediction._score2234 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "score", "D");
		}
	}
}
