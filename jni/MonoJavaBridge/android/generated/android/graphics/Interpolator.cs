namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Interpolator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Interpolator()
		{
			InitJNI();
		}
		protected Interpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Result : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Result()
			{
				InitJNI();
			}
			internal Result(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3313;
			public static global::android.graphics.Interpolator.Result[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._values3313)) as android.graphics.Interpolator.Result[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3314;
			public static global::android.graphics.Interpolator.Result valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._valueOf3314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_END3315;
			public static global::android.graphics.Interpolator.Result FREEZE_END
			{
				get
				{
					return default(global::android.graphics.Interpolator.Result);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_START3316;
			public static global::android.graphics.Interpolator.Result FREEZE_START
			{
				get
				{
					return default(global::android.graphics.Interpolator.Result);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL3317;
			public static global::android.graphics.Interpolator.Result NORMAL
			{
				get
				{
					return default(global::android.graphics.Interpolator.Result);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Interpolator.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator$Result"));
				global::android.graphics.Interpolator.Result._values3313 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;");
				global::android.graphics.Interpolator.Result._valueOf3314 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3318;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._finalize3318);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._finalize3318);
		}
		internal static global::MonoJavaBridge.MethodId _reset3319;
		public virtual void reset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._reset3319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset3319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset3320;
		public virtual void reset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._reset3320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset3320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyFrameCount3321;
		public virtual int getKeyFrameCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Interpolator._getKeyFrameCount3321);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getKeyFrameCount3321);
		}
		internal static global::MonoJavaBridge.MethodId _getValueCount3322;
		public virtual int getValueCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Interpolator._getValueCount3322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getValueCount3322);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame3323;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setKeyFrame3323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame3323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame3324;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setKeyFrame3324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame3324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMirror3325;
		public virtual void setRepeatMirror(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setRepeatMirror3325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setRepeatMirror3325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues3326;
		public virtual global::android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Interpolator._timeToValues3326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Interpolator.Result;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues3326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues3327;
		public virtual global::android.graphics.Interpolator.Result timeToValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Interpolator._timeToValues3327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues3327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator3328;
		public Interpolator(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator3328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator3329;
		public Interpolator(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator3329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Interpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator"));
			global::android.graphics.Interpolator._finalize3318 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "finalize", "()V");
			global::android.graphics.Interpolator._reset3319 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "reset", "(II)V");
			global::android.graphics.Interpolator._reset3320 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "reset", "(I)V");
			global::android.graphics.Interpolator._getKeyFrameCount3321 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I");
			global::android.graphics.Interpolator._getValueCount3322 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "getValueCount", "()I");
			global::android.graphics.Interpolator._setKeyFrame3323 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V");
			global::android.graphics.Interpolator._setKeyFrame3324 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V");
			global::android.graphics.Interpolator._setRepeatMirror3325 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V");
			global::android.graphics.Interpolator._timeToValues3326 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;");
			global::android.graphics.Interpolator._timeToValues3327 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;");
			global::android.graphics.Interpolator._Interpolator3328 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V");
			global::android.graphics.Interpolator._Interpolator3329 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V");
		}
	}
}
