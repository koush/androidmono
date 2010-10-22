namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable_))]
	public abstract partial class Drawable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Drawable()
		{
			InitJNI();
		}
		protected Drawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.graphics.drawable.Drawable.Callback_))]
		public interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void invalidateDrawable(android.graphics.drawable.Drawable arg0);
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2);
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.Callback))]
		public sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback_()
			{
				InitJNI();
			}
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _invalidateDrawable5898;
			 void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable5898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable5898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _scheduleDrawable5899;
			 void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable5899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable5899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _unscheduleDrawable5900;
			 void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable5900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable5900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$Callback"));
				global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable5898 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable5899 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
				global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable5900 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable.ConstantState_))]
		public abstract partial class ConstantState : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ConstantState()
			{
				InitJNI();
			}
			protected ConstantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5901;
			public abstract int getChangingConfigurations();
			internal static global::MonoJavaBridge.MethodId _newDrawable5902;
			public abstract global::android.graphics.drawable.Drawable newDrawable();
			internal static global::MonoJavaBridge.MethodId _newDrawable5903;
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState._newDrawable5903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._newDrawable5903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _ConstantState5904;
			public ConstantState()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._ConstantState5904);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations5901 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable5902 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable5903 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState5904 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.ConstantState))]
		public sealed partial class ConstantState_ : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ConstantState_()
			{
				InitJNI();
			}
			internal ConstantState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5905;
			public override int getChangingConfigurations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations5905);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations5905);
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable5906;
			public override global::android.graphics.drawable.Drawable newDrawable() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._newDrawable5906)) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, global::android.graphics.drawable.Drawable.ConstantState_._newDrawable5906)) as android.graphics.drawable.Drawable;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations5905 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState_._newDrawable5906 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState5907;
		public virtual int[] getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getState5907)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getState5907)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setState5908;
		public virtual bool setState(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setState5908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setState5908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate5909;
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._inflate5909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._inflate5909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5910;
		public abstract void draw(android.graphics.Canvas arg0);
		internal static global::MonoJavaBridge.MethodId _setBounds5911;
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setBounds5911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds5911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBounds5912;
		public virtual void setBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setBounds5912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds5912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds5913;
		public virtual void copyBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._copyBounds5913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds5913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds5914;
		public virtual global::android.graphics.Rect copyBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._copyBounds5914)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds5914)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5915;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getBounds5915)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getBounds5915)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _setChangingConfigurations5916;
		public virtual void setChangingConfigurations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setChangingConfigurations5916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setChangingConfigurations5916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5917;
		public virtual int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getChangingConfigurations5917);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getChangingConfigurations5917);
		}
		internal static global::MonoJavaBridge.MethodId _setDither5918;
		public virtual void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setDither5918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setDither5918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap5919;
		public virtual void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setFilterBitmap5919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setFilterBitmap5919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback5920;
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setCallback5920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setCallback5920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateSelf5921;
		public virtual void invalidateSelf() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._invalidateSelf5921);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._invalidateSelf5921);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleSelf5922;
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._scheduleSelf5922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._scheduleSelf5922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleSelf5923;
		public virtual void unscheduleSelf(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._unscheduleSelf5923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._unscheduleSelf5923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5924;
		public abstract void setAlpha(int arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter5925;
		public abstract void setColorFilter(android.graphics.ColorFilter arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter5926;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setColorFilter5926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setColorFilter5926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter5927;
		public virtual void clearColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._clearColorFilter5927);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._clearColorFilter5927);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful5928;
		public virtual bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._isStateful5928);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isStateful5928);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent5929;
		public virtual global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getCurrent5929)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getCurrent5929)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setLevel5930;
		public virtual bool setLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setLevel5930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setLevel5930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLevel5931;
		public virtual int getLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getLevel5931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getLevel5931);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5932;
		public virtual bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setVisible5932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setVisible5932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible5933;
		public virtual bool isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._isVisible5933);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isVisible5933);
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5934;
		public abstract int getOpacity();
		internal static global::MonoJavaBridge.MethodId _resolveOpacity5935;
		public static int resolveOpacity(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._resolveOpacity5935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion5936;
		public virtual global::android.graphics.Region getTransparentRegion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getTransparentRegion5936)) as android.graphics.Region;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getTransparentRegion5936)) as android.graphics.Region;
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange5937;
		protected virtual bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onStateChange5937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onStateChange5937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange5938;
		protected virtual bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onLevelChange5938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onLevelChange5938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5939;
		protected virtual void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onBoundsChange5939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onBoundsChange5939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5940;
		public virtual int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getIntrinsicWidth5940);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicWidth5940);
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5941;
		public virtual int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getIntrinsicHeight5941);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicHeight5941);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth5942;
		public virtual int getMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getMinimumWidth5942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumWidth5942);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight5943;
		public virtual int getMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getMinimumHeight5943);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumHeight5943);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding5944;
		public virtual bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getPadding5944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getPadding5944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate5945;
		public virtual global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._mutate5945)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._mutate5945)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream5946;
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromStream5946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream5947;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream5947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream5948;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream5948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml5949;
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXml5949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXmlInner5950;
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXmlInner5950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromPath5951;
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromPath5951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5952;
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getConstantState5952)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getConstantState5952)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _Drawable5953;
		public Drawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._Drawable5953);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable._getState5907 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I");
			global::android.graphics.drawable.Drawable._setState5908 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z");
			global::android.graphics.drawable.Drawable._inflate5909 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.Drawable._draw5910 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable._setBounds5911 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V");
			global::android.graphics.drawable.Drawable._setBounds5912 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds5913 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds5914 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._getBounds5915 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._setChangingConfigurations5916 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V");
			global::android.graphics.drawable.Drawable._getChangingConfigurations5917 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.Drawable._setDither5918 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.Drawable._setFilterBitmap5919 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.Drawable._setCallback5920 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V");
			global::android.graphics.drawable.Drawable._invalidateSelf5921 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V");
			global::android.graphics.drawable.Drawable._scheduleSelf5922 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.Drawable._unscheduleSelf5923 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.Drawable._setAlpha5924 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable._setColorFilter5925 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable._setColorFilter5926 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.drawable.Drawable._clearColorFilter5927 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V");
			global::android.graphics.drawable.Drawable._isStateful5928 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.Drawable._getCurrent5929 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._setLevel5930 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z");
			global::android.graphics.drawable.Drawable._getLevel5931 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I");
			global::android.graphics.drawable.Drawable._setVisible5932 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.Drawable._isVisible5933 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z");
			global::android.graphics.drawable.Drawable._getOpacity5934 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.Drawable._resolveOpacity5935 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I");
			global::android.graphics.drawable.Drawable._getTransparentRegion5936 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;");
			global::android.graphics.drawable.Drawable._onStateChange5937 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.Drawable._onLevelChange5938 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.Drawable._onBoundsChange5939 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._getIntrinsicWidth5940 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.Drawable._getIntrinsicHeight5941 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.Drawable._getMinimumWidth5942 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.Drawable._getMinimumHeight5943 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.Drawable._getPadding5944 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.Drawable._mutate5945 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromStream5946 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream5947 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream5948 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXml5949 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXmlInner5950 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromPath5951 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._getConstantState5952 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.Drawable._Drawable5953 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable))]
	public sealed partial class Drawable_ : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Drawable_()
		{
			InitJNI();
		}
		internal Drawable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw5954;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._draw5954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._draw5954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5955;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setAlpha5955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._setAlpha5955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5956;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setColorFilter5956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._setColorFilter5956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5957;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._getOpacity5957);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._getOpacity5957);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable_._draw5954 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable_._setAlpha5955 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable_._setColorFilter5956 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable_._getOpacity5957 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "getOpacity", "()I");
		}
	}
}
