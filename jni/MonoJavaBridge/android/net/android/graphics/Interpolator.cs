namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Interpolator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Interpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Interpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Interpolator.Result), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2736; 
			public static android.graphics.Interpolator.Result valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Interpolator.Result.staticClass, _valueOf2736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2737; 
			public static android.graphics.Interpolator.Result[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Interpolator.Result.staticClass, _values2737)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FREEZE_END2738; 
			public static android.graphics.Interpolator.Result FREEZE_END
			{ 
				get 
				{ 
					return default(android.graphics.Interpolator.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FREEZE_START2739; 
			public static android.graphics.Interpolator.Result FREEZE_START
			{ 
				get 
				{ 
					return default(android.graphics.Interpolator.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL2740; 
			public static android.graphics.Interpolator.Result NORMAL
			{ 
				get 
				{ 
					return default(android.graphics.Interpolator.Result); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Interpolator.Result.staticClass = @__class; 
				global::android.graphics.Interpolator.Result._valueOf2736 = @__env.GetStaticMethodID(global::android.graphics.Interpolator.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;"); 
				global::android.graphics.Interpolator.Result._values2737 = @__env.GetStaticMethodID(global::android.graphics.Interpolator.Result.staticClass, "values", "()[Landroid/graphics/Interpolator/Result;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2741; 
		public virtual void reset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				@__env.CallVoidMethod(this, _reset2741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Interpolator.staticClass, _reset2741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2742; 
		public virtual void reset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				@__env.CallVoidMethod(this, _reset2742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Interpolator.staticClass, _reset2742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyFrameCount2743; 
		public virtual int getKeyFrameCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				return @__env.CallIntMethod(this, _getKeyFrameCount2743); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Interpolator.staticClass, _getKeyFrameCount2743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValueCount2744; 
		public virtual int getValueCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				return @__env.CallIntMethod(this, _getValueCount2744); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Interpolator.staticClass, _getValueCount2744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyFrame2745; 
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				@__env.CallVoidMethod(this, _setKeyFrame2745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Interpolator.staticClass, _setKeyFrame2745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyFrame2746; 
		public virtual void setKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				@__env.CallVoidMethod(this, _setKeyFrame2746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Interpolator.staticClass, _setKeyFrame2746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMirror2747; 
		public virtual void setRepeatMirror(float arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				@__env.CallVoidMethod(this, _setRepeatMirror2747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Interpolator.staticClass, _setRepeatMirror2747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timeToValues2748; 
		public virtual android.graphics.Interpolator.Result timeToValues(int arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallObjectMethodPtr(this, _timeToValues2748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Interpolator.staticClass, _timeToValues2748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timeToValues2749; 
		public virtual android.graphics.Interpolator.Result timeToValues(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Interpolator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallObjectMethodPtr(this, _timeToValues2749, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Interpolator.Result>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Interpolator.staticClass, _timeToValues2749, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Interpolator2750; 
		public Interpolator(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Interpolator.staticClass, _Interpolator2750, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Interpolator2751; 
		public Interpolator(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Interpolator.staticClass, _Interpolator2751, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Interpolator.staticClass = @__class; 
			global::android.graphics.Interpolator._reset2741 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "reset", "(II)V"); 
			global::android.graphics.Interpolator._reset2742 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "reset", "(I)V"); 
			global::android.graphics.Interpolator._getKeyFrameCount2743 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "getKeyFrameCount", "()I"); 
			global::android.graphics.Interpolator._getValueCount2744 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "getValueCount", "()I"); 
			global::android.graphics.Interpolator._setKeyFrame2745 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F)V"); 
			global::android.graphics.Interpolator._setKeyFrame2746 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setKeyFrame", "(II[F[F)V"); 
			global::android.graphics.Interpolator._setRepeatMirror2747 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "setRepeatMirror", "(FZ)V"); 
			global::android.graphics.Interpolator._timeToValues2748 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;"); 
			global::android.graphics.Interpolator._timeToValues2749 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "timeToValues", "([F)Landroid/graphics/Interpolator$Result;"); 
			global::android.graphics.Interpolator._Interpolator2750 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "<init>", "(I)V"); 
			global::android.graphics.Interpolator._Interpolator2751 = @__env.GetMethodID(global::android.graphics.Interpolator.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
