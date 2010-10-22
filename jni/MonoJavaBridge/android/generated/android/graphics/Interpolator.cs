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
			internal static global::MonoJavaBridge.MethodId _values5256;
			public static global::android.graphics.Interpolator.Result[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._values5256)) as android.graphics.Interpolator.Result[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5257;
			public static global::android.graphics.Interpolator.Result valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallStaticObjectMethod(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._valueOf5257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_END5258;
			public static global::android.graphics.Interpolator.Result FREEZE_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_END5258)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FREEZE_START5259;
			public static global::android.graphics.Interpolator.Result FREEZE_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _FREEZE_START5259)) as android.graphics.Interpolator.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5260;
			public static global::android.graphics.Interpolator.Result NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.GetStaticObjectField(global::android.graphics.Interpolator.Result.staticClass, _NORMAL5260)) as android.graphics.Interpolator.Result;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Interpolator.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator$Result"));
				global::android.graphics.Interpolator.Result._values5256 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;");
				global::android.graphics.Interpolator.Result._valueOf5257 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._FREEZE_END5258 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_END", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._FREEZE_START5259 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "FREEZE_START", "Landroid/graphics/Interpolator$Result;");
				global::android.graphics.Interpolator.Result._NORMAL5260 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Interpolator.Result.staticClass, "NORMAL", "Landroid/graphics/Interpolator$Result;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5261;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._finalize5261);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._finalize5261);
		}
		internal static global::MonoJavaBridge.MethodId _reset5262;
		public virtual void reset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._reset5262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset5262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset5263;
		public virtual void reset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._reset5263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset5263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int KeyFrameCount
		{
			get
			{
				return getKeyFrameCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyFrameCount5264;
		public virtual int getKeyFrameCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Interpolator._getKeyFrameCount5264);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getKeyFrameCount5264);
		}
		public new int ValueCount
		{
			get
			{
				return getValueCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValueCount5265;
		public virtual int getValueCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Interpolator._getValueCount5265);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getValueCount5265);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame5266;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setKeyFrame5266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame5266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyFrame5267;
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setKeyFrame5267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame5267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMirror5268;
		public virtual void setRepeatMirror(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Interpolator._setRepeatMirror5268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setRepeatMirror5268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues5269;
		public virtual global::android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Interpolator._timeToValues5269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Interpolator.Result;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues5269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _timeToValues5270;
		public virtual global::android.graphics.Interpolator.Result timeToValues(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Interpolator._timeToValues5270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Interpolator.Result>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues5270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Interpolator.Result;
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator5271;
		public Interpolator(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator5271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Interpolator5272;
		public Interpolator(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator5272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Interpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Interpolator"));
			global::android.graphics.Interpolator._finalize5261 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "finalize", "()V");
			global::android.graphics.Interpolator._reset5262 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "reset", "(II)V");
			global::android.graphics.Interpolator._reset5263 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "reset", "(I)V");
			global::android.graphics.Interpolator._getKeyFrameCount5264 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I");
			global::android.graphics.Interpolator._getValueCount5265 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "getValueCount", "()I");
			global::android.graphics.Interpolator._setKeyFrame5266 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V");
			global::android.graphics.Interpolator._setKeyFrame5267 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V");
			global::android.graphics.Interpolator._setRepeatMirror5268 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V");
			global::android.graphics.Interpolator._timeToValues5269 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;");
			global::android.graphics.Interpolator._timeToValues5270 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;");
			global::android.graphics.Interpolator._Interpolator5271 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V");
			global::android.graphics.Interpolator._Interpolator5272 = @__env.GetMethodIDNoThrow(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V");
		}
	}
}
