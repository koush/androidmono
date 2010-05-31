namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Interpolator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Interpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Interpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Interpolator(@__env); 
			} 
		} 
		protected Interpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Result : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Result() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Interpolator.Result), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Interpolator.Result(@__env); 
				} 
			} 
			internal Result(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2936; 
			public static global::android.graphics.Interpolator.Result valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._valueOf2936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2937; 
			public static global::android.graphics.Interpolator.Result[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Interpolator.Result.staticClass, global::android.graphics.Interpolator.Result._values2937)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FREEZE_END2938; 
			public static global::android.graphics.Interpolator.Result FREEZE_END
			{ 
				get 
				{ 
					return default(global::android.graphics.Interpolator.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FREEZE_START2939; 
			public static global::android.graphics.Interpolator.Result FREEZE_START
			{ 
				get 
				{ 
					return default(global::android.graphics.Interpolator.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL2940; 
			public static global::android.graphics.Interpolator.Result NORMAL
			{ 
				get 
				{ 
					return default(global::android.graphics.Interpolator.Result); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Interpolator.Result.staticClass = @__class; 
				global::android.graphics.Interpolator.Result._valueOf2936 = @__env.GetStaticMethodID(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;"); 
				global::android.graphics.Interpolator.Result._values2937 = @__env.GetStaticMethodID(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2941; 
		public virtual void reset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Interpolator._reset2941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset2941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2942; 
		public virtual void reset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Interpolator._reset2942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._reset2942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyFrameCount2943; 
		public virtual int getKeyFrameCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.Interpolator._getKeyFrameCount2943); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getKeyFrameCount2943); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValueCount2944; 
		public virtual int getValueCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.Interpolator._getValueCount2944); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._getValueCount2944); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyFrame2945; 
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Interpolator._setKeyFrame2945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame2945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyFrame2946; 
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Interpolator._setKeyFrame2946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setKeyFrame2946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMirror2947; 
		public virtual void setRepeatMirror(float arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Interpolator._setRepeatMirror2947, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._setRepeatMirror2947, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timeToValues2948; 
		public virtual global::android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Interpolator._timeToValues2948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues2948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timeToValues2949; 
		public virtual global::android.graphics.Interpolator.Result timeToValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Interpolator._timeToValues2949, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._timeToValues2949, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Interpolator2950; 
		public Interpolator(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator2950, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Interpolator2951; 
		public Interpolator(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Interpolator.staticClass, global::android.graphics.Interpolator._Interpolator2951, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Interpolator.staticClass = @__class; 
			global::android.graphics.Interpolator._reset2941 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "reset", "(II)V"); 
			global::android.graphics.Interpolator._reset2942 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "reset", "(I)V"); 
			global::android.graphics.Interpolator._getKeyFrameCount2943 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I"); 
			global::android.graphics.Interpolator._getValueCount2944 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "getValueCount", "()I"); 
			global::android.graphics.Interpolator._setKeyFrame2945 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V"); 
			global::android.graphics.Interpolator._setKeyFrame2946 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V"); 
			global::android.graphics.Interpolator._setRepeatMirror2947 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V"); 
			global::android.graphics.Interpolator._timeToValues2948 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;"); 
			global::android.graphics.Interpolator._timeToValues2949 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;"); 
			global::android.graphics.Interpolator._Interpolator2950 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V"); 
			global::android.graphics.Interpolator._Interpolator2951 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
