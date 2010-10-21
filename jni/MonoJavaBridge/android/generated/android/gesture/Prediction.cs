namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Prediction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Prediction()
		{
			InitJNI();
		}
		protected Prediction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4987;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Prediction._toString4987)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Prediction.staticClass, global::android.gesture.Prediction._toString4987)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _name4988;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _name4988)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _score4989;
		public double score
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _score4989);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Prediction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Prediction"));
			global::android.gesture.Prediction._toString4987 = @__env.GetMethodIDNoThrow(global::android.gesture.Prediction.staticClass, "toString", "()Ljava/lang/String;");
			global::android.gesture.Prediction._name4988 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "name", "Ljava/lang/String;");
			global::android.gesture.Prediction._score4989 = @__env.GetFieldIDNoThrow(global::android.gesture.Prediction.staticClass, "score", "D");
		}
	}
}
