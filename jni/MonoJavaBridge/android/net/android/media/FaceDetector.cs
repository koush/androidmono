namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class FaceDetector : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static FaceDetector() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.FaceDetector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.FaceDetector(@__env); 
			} 
		} 
		protected FaceDetector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Face : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Face() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.FaceDetector.Face), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.FaceDetector.Face(@__env); 
				} 
			} 
			protected Face(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _confidence4462; 
			public virtual float confidence() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallFloatMethod(this, global::android.media.FaceDetector.Face._confidence4462); 
				else 
					return @__env.CallNonVirtualFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._confidence4462); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getMidPoint4463; 
			public virtual void getMidPoint(android.graphics.PointF arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.FaceDetector.Face._getMidPoint4463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._getMidPoint4463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _eyesDistance4464; 
			public virtual float eyesDistance() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallFloatMethod(this, global::android.media.FaceDetector.Face._eyesDistance4464); 
				else 
					return @__env.CallNonVirtualFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._eyesDistance4464); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _pose4465; 
			public virtual float pose(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallFloatMethod(this, global::android.media.FaceDetector.Face._pose4465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualFloatMethod(this, global::android.media.FaceDetector.Face.staticClass, global::android.media.FaceDetector.Face._pose4465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.FaceDetector.Face.staticClass = @__class; 
				global::android.media.FaceDetector.Face._confidence4462 = @__env.GetMethodID(global::android.media.FaceDetector.Face.staticClass, "confidence", "()F"); 
				global::android.media.FaceDetector.Face._getMidPoint4463 = @__env.GetMethodID(global::android.media.FaceDetector.Face.staticClass, "getMidPoint", "(Landroid/graphics/PointF;)V"); 
				global::android.media.FaceDetector.Face._eyesDistance4464 = @__env.GetMethodID(global::android.media.FaceDetector.Face.staticClass, "eyesDistance", "()F"); 
				global::android.media.FaceDetector.Face._pose4465 = @__env.GetMethodID(global::android.media.FaceDetector.Face.staticClass, "pose", "(I)F"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findFaces4466; 
		public virtual int findFaces(android.graphics.Bitmap arg0, android.media.FaceDetector.Face[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.FaceDetector._findFaces4466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.FaceDetector.staticClass, global::android.media.FaceDetector._findFaces4466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FaceDetector4467; 
		public FaceDetector(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.FaceDetector.staticClass, global::android.media.FaceDetector._FaceDetector4467, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.FaceDetector.staticClass = @__class; 
			global::android.media.FaceDetector._findFaces4466 = @__env.GetMethodID(global::android.media.FaceDetector.staticClass, "findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector/Face;)I"); 
			global::android.media.FaceDetector._FaceDetector4467 = @__env.GetMethodID(global::android.media.FaceDetector.staticClass, "<init>", "(III)V"); 
		} 
	} 
} 
