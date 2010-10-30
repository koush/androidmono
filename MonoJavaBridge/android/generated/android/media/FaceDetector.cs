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
			internal static global::MonoJavaBridge.MethodId _confidence7282;
			public virtual float confidence()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.FaceDetector.Face._confidence7282.native == global::System.IntPtr.Zero)
					global::android.media.FaceDetector.Face._confidence7282 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "confidence", "()F");
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._confidence7282);
			}
			internal static global::MonoJavaBridge.MethodId _getMidPoint7283;
			public virtual void getMidPoint(android.graphics.PointF arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.FaceDetector.Face._getMidPoint7283.native == global::System.IntPtr.Zero)
					global::android.media.FaceDetector.Face._getMidPoint7283 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "getMidPoint", "(Landroid/graphics/PointF;)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._getMidPoint7283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _eyesDistance7284;
			public virtual float eyesDistance()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.FaceDetector.Face._eyesDistance7284.native == global::System.IntPtr.Zero)
					global::android.media.FaceDetector.Face._eyesDistance7284 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "eyesDistance", "()F");
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._eyesDistance7284);
			}
			internal static global::MonoJavaBridge.MethodId _pose7285;
			public virtual float pose(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.FaceDetector.Face._pose7285.native == global::System.IntPtr.Zero)
					global::android.media.FaceDetector.Face._pose7285 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "pose", "(I)F");
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._pose7285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7290;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.FaceDetector._finalize7290.native == global::System.IntPtr.Zero)
				global::android.media.FaceDetector._finalize7290 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.FaceDetector.staticClass, global::android.media.FaceDetector._finalize7290);
		}
		internal static global::MonoJavaBridge.MethodId _findFaces7291;
		public virtual int findFaces(android.graphics.Bitmap arg0, android.media.FaceDetector.Face[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.FaceDetector._findFaces7291.native == global::System.IntPtr.Zero)
				global::android.media.FaceDetector._findFaces7291 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector/Face;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.FaceDetector.staticClass, global::android.media.FaceDetector._findFaces7291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _FaceDetector7292;
		public FaceDetector(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.FaceDetector._FaceDetector7292.native == global::System.IntPtr.Zero)
				global::android.media.FaceDetector._FaceDetector7292 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.FaceDetector.staticClass, global::android.media.FaceDetector._FaceDetector7292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static FaceDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.FaceDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/FaceDetector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
