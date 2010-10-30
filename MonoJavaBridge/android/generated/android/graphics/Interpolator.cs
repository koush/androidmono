namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Interpolator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Interpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Result : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Result(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Interpolator.Result[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Interpolator.Result._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Interpolator.Result._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._m0)) as android.graphics.Interpolator.Result[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Interpolator.Result valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Interpolator.Result._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Interpolator.Result._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_END2293;
			public static global::android.graphics.Interpolator.Result FREEZE_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_END2293)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_START2294;
			public static global::android.graphics.Interpolator.Result FREEZE_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_START2294)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL2295;
			public static global::android.graphics.Interpolator.Result NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _NORMAL2295)) as android.graphics.Interpolator.Result;
				}
			}
			static Result()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Interpolator.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator$Result"));
				global::android.graphics.Interpolator.Result._FREEZE_END2293 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_END", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._FREEZE_START2294 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_START", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._NORMAL2295 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "NORMAL", "Landroid/graphics/Interpolator$Result;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "finalize", "()V", ref global::android.graphics.Interpolator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void reset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "reset", "(II)V", ref global::android.graphics.Interpolator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "reset", "(I)V", ref global::android.graphics.Interpolator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int KeyFrameCount
		{
			get
			{
				return getKeyFrameCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getKeyFrameCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I", ref global::android.graphics.Interpolator._m3);
		}
		public new int ValueCount
		{
			get
			{
				return getValueCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getValueCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Interpolator.staticClass, "getValueCount", "()I", ref global::android.graphics.Interpolator._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V", ref global::android.graphics.Interpolator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V", ref global::android.graphics.Interpolator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setRepeatMirror(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V", ref global::android.graphics.Interpolator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Interpolator.Result>(this, global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;", ref global::android.graphics.Interpolator._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Interpolator.Result;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.graphics.Interpolator.Result timeToValues(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Interpolator.Result>(this, global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;", ref global::android.graphics.Interpolator._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Interpolator.Result;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Interpolator(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Interpolator._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.Interpolator._m10 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Interpolator(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Interpolator._m11.native == global::System.IntPtr.Zero)
				global::android.graphics.Interpolator._m11 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Interpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Interpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
