namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FaceDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FaceDetector()
		{
			InitJNI();
		}
		protected FaceDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Face : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Face()
			{
				InitJNI();
			}
			protected Face(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _confidence7254;
			public virtual float confidence() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face._confidence7254);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._confidence7254);
			}
			internal static global::MonoJavaBridge.MethodId _getMidPoint7255;
			public virtual void getMidPoint(android.graphics.PointF arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.FaceDetector.Face._getMidPoint7255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._getMidPoint7255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _eyesDistance7256;
			public virtual float eyesDistance() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face._eyesDistance7256);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._eyesDistance7256);
			}
			internal static global::MonoJavaBridge.MethodId _pose7257;
			public virtual float pose(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face._pose7257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._pose7257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.FaceDetector.Face.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/FaceDetector$Face"));
				global::android.media.FaceDetector.Face._confidence7254 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "confidence", "()F");
				global::android.media.FaceDetector.Face._getMidPoint7255 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "getMidPoint", "(Landroid/graphics/PointF;)V");
				global::android.media.FaceDetector.Face._eyesDistance7256 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "eyesDistance", "()F");
				global::android.media.FaceDetector.Face._pose7257 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.Face.staticClass, "pose", "(I)F");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7262;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.FaceDetector._finalize7262);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.FaceDetector.staticClass, global::android.media.FaceDetector._finalize7262);
		}
		internal static global::MonoJavaBridge.MethodId _findFaces7263;
		public virtual int findFaces(android.graphics.Bitmap arg0, android.media.FaceDetector.Face[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.FaceDetector._findFaces7263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.FaceDetector.staticClass, global::android.media.FaceDetector._findFaces7263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _FaceDetector7264;
		public FaceDetector(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.FaceDetector.staticClass, global::android.media.FaceDetector._FaceDetector7264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.FaceDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/FaceDetector"));
			global::android.media.FaceDetector._finalize7262 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "finalize", "()V");
			global::android.media.FaceDetector._findFaces7263 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector/Face;)I");
			global::android.media.FaceDetector._FaceDetector7264 = @__env.GetMethodIDNoThrow(global::android.media.FaceDetector.staticClass, "<init>", "(III)V");
		}
	}
}
