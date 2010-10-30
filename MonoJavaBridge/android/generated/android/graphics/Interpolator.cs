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
			internal static global::MonoJavaBridge.MethodId _values5275;
			public static global::android.graphics.Interpolator.Result[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Interpolator.Result._values5275.native == global::System.IntPtr.Zero)
					global::android.graphics.Interpolator.Result._values5275 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._values5275)) as android.graphics.Interpolator.Result[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5276;
			public static global::android.graphics.Interpolator.Result valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Interpolator.Result._valueOf5276.native == global::System.IntPtr.Zero)
					global::android.graphics.Interpolator.Result._valueOf5276 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._valueOf5276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_END5277;
			public static global::android.graphics.Interpolator.Result FREEZE_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_END5277)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_START5278;
			public static global::android.graphics.Interpolator.Result FREEZE_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_START5278)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5279;
			public static global::android.graphics.Interpolator.Result NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _NORMAL5279)) as android.graphics.Interpolator.Result;
				}
			}
			static Result()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Interpolator.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator$Result"));
				global::android.graphics.Interpolator.Result._FREEZE_END5277 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_END", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._FREEZE_START5278 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_START", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._NORMAL5279 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "NORMAL", "Landroid/graphics/Interpolator$Result;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5280;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "finalize", "()V", ref global::android.graphics.Interpolator._finalize5280);
		}
		internal static global::MonoJavaBridge.MethodId _reset5281;
		public virtual void reset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "reset", "(II)V", ref global::android.graphics.Interpolator._reset5281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset5282;
		public virtual void reset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "reset", "(I)V", ref global::android.graphics.Interpolator._reset5282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int KeyFrameCount
		{
			get
			{
				return getKeyFrameCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyFrameCount5283;
		public virtual int getKeyFrameCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I", ref global::android.graphics.Interpolator._getKeyFrameCount5283);
		}
		public new int ValueCount
		{
			get
			{
				return getValueCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValueCount5284;
		public virtual int getValueCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Interpolator.staticClass, "getValueCount", "()I", ref global::android.graphics.Interpolator._getValueCount5284);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame5285;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V", ref global::android.graphics.Interpolator._setKeyFrame5285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame5286;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V", ref global::android.graphics.Interpolator._setKeyFrame5286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMirror5287;
		public virtual void setRepeatMirror(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V", ref global::android.graphics.Interpolator._setRepeatMirror5287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues5288;
		public virtual global::android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Interpolator.Result>(this, global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;", ref global::android.graphics.Interpolator._timeToValues5288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues5289;
		public virtual global::android.graphics.Interpolator.Result timeToValues(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Interpolator.Result>(this, global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;", ref global::android.graphics.Interpolator._timeToValues5289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator5290;
		public Interpolator(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Interpolator._Interpolator5290.native == global::System.IntPtr.Zero)
				global::android.graphics.Interpolator._Interpolator5290 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator5290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator5291;
		public Interpolator(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Interpolator._Interpolator5291.native == global::System.IntPtr.Zero)
				global::android.graphics.Interpolator._Interpolator5291 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator5291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
