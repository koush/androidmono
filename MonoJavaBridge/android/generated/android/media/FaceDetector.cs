namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FaceDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FaceDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Face : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Face(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual float confidence()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, "confidence", "()F", ref global::android.media.FaceDetector.Face._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void getMidPoint(android.graphics.PointF arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.FaceDetector.Face.staticClass, "getMidPoint", "(Landroid/graphics/PointF;)V", ref global::android.media.FaceDetector.Face._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual float eyesDistance()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, "eyesDistance", "()F", ref global::android.media.FaceDetector.Face._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual float pose(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, "pose", "(I)F", ref global::android.media.FaceDetector.Face._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public static float CONFIDENCE_THRESHOLD
			{
				get
				{
					return 0.4f;
				}
			}
			public static int EULER_X
			{
				get
				{
					return 0;
				}
			}
			public static int EULER_Y
			{
				get
				{
					return 1;
				}
			}
			public static int EULER_Z
			{
				get
				{
					return 2;
				}
			}
			static Face()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.FaceDetector.Face.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/FaceDetector$Face"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.FaceDetector.staticClass, "finalize", "()V", ref global::android.media.FaceDetector._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int findFaces(android.graphics.Bitmap arg0, android.media.FaceDetector.Face[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.FaceDetector.staticClass, "findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector/Face;)I", ref global::android.media.FaceDetector._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FaceDetector(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.FaceDetector._m2.native == global::System.IntPtr.Zero)
				global::android.media.FaceDetector._m2 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.FaceDetector.staticClass, global::android.media.FaceDetector._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static FaceDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.FaceDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/FaceDetector"));
		}
	}
}
