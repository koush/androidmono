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
			internal static global::MonoJavaBridge.MethodId _invalidateDrawable3911;
			 void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable3911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable3911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _scheduleDrawable3912;
			 void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable3912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable3912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _unscheduleDrawable3913;
			 void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable3913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_.staticClass, global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable3913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$Callback"));
				global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable3911 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable3912 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
				global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable3913 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
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
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3914;
			public abstract int getChangingConfigurations();
			internal static global::MonoJavaBridge.MethodId _newDrawable3915;
			public abstract global::android.graphics.drawable.Drawable newDrawable();
			internal static global::MonoJavaBridge.MethodId _newDrawable3916;
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._newDrawable3916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _ConstantState3917;
			public ConstantState()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._ConstantState3917);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations3914 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3915 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3916 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState3917 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3918;
			public override int getChangingConfigurations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations3918);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations3918);
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable3919;
			public override global::android.graphics.drawable.Drawable newDrawable() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._newDrawable3919)) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_.staticClass, global::android.graphics.drawable.Drawable.ConstantState_._newDrawable3919)) as android.graphics.drawable.Drawable;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations3918 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState_._newDrawable3919 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState3920;
		public virtual int[] getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getState3920)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getState3920)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setState3921;
		public virtual bool setState(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setState3921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setState3921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate3922;
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._inflate3922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._inflate3922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw3923;
		public abstract void draw(android.graphics.Canvas arg0);
		internal static global::MonoJavaBridge.MethodId _setBounds3924;
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setBounds3924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBounds3925;
		public virtual void setBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setBounds3925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds3925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds3926;
		public virtual void copyBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._copyBounds3926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds3927;
		public virtual global::android.graphics.Rect copyBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._copyBounds3927)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds3927)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds3928;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getBounds3928)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getBounds3928)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _setChangingConfigurations3929;
		public virtual void setChangingConfigurations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setChangingConfigurations3929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setChangingConfigurations3929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3930;
		public virtual int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getChangingConfigurations3930);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getChangingConfigurations3930);
		}
		internal static global::MonoJavaBridge.MethodId _setDither3931;
		public virtual void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setDither3931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setDither3931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap3932;
		public virtual void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setFilterBitmap3932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setFilterBitmap3932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback3933;
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setCallback3933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setCallback3933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateSelf3934;
		public virtual void invalidateSelf() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._invalidateSelf3934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._invalidateSelf3934);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleSelf3935;
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._scheduleSelf3935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._scheduleSelf3935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleSelf3936;
		public virtual void unscheduleSelf(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._unscheduleSelf3936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._unscheduleSelf3936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3937;
		public abstract void setAlpha(int arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter3938;
		public abstract void setColorFilter(android.graphics.ColorFilter arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter3939;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setColorFilter3939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setColorFilter3939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter3940;
		public virtual void clearColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._clearColorFilter3940);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._clearColorFilter3940);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful3941;
		public virtual bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._isStateful3941);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isStateful3941);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent3942;
		public virtual global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getCurrent3942)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getCurrent3942)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setLevel3943;
		public virtual bool setLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setLevel3943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setLevel3943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLevel3944;
		public virtual int getLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getLevel3944);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getLevel3944);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible3945;
		public virtual bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._setVisible3945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setVisible3945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible3946;
		public virtual bool isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._isVisible3946);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isVisible3946);
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity3947;
		public abstract int getOpacity();
		internal static global::MonoJavaBridge.MethodId _resolveOpacity3948;
		public static int resolveOpacity(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._resolveOpacity3948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion3949;
		public virtual global::android.graphics.Region getTransparentRegion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getTransparentRegion3949)) as android.graphics.Region;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getTransparentRegion3949)) as android.graphics.Region;
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange3950;
		protected virtual bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onStateChange3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onStateChange3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange3951;
		protected virtual bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onLevelChange3951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onLevelChange3951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange3952;
		protected virtual void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._onBoundsChange3952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onBoundsChange3952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth3953;
		public virtual int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getIntrinsicWidth3953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicWidth3953);
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight3954;
		public virtual int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getIntrinsicHeight3954);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicHeight3954);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth3955;
		public virtual int getMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getMinimumWidth3955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumWidth3955);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight3956;
		public virtual int getMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getMinimumHeight3956);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumHeight3956);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding3957;
		public virtual bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getPadding3957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getPadding3957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate3958;
		public virtual global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._mutate3958)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._mutate3958)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream3959;
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromStream3959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream3960;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream3961;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream3961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml3962;
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXml3962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXmlInner3963;
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXmlInner3963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromPath3964;
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromPath3964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState3965;
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable._getConstantState3965)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getConstantState3965)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _Drawable3966;
		public Drawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._Drawable3966);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable._getState3920 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I");
			global::android.graphics.drawable.Drawable._setState3921 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z");
			global::android.graphics.drawable.Drawable._inflate3922 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.Drawable._draw3923 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable._setBounds3924 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V");
			global::android.graphics.drawable.Drawable._setBounds3925 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds3926 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds3927 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._getBounds3928 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._setChangingConfigurations3929 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V");
			global::android.graphics.drawable.Drawable._getChangingConfigurations3930 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.Drawable._setDither3931 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.Drawable._setFilterBitmap3932 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.Drawable._setCallback3933 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V");
			global::android.graphics.drawable.Drawable._invalidateSelf3934 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V");
			global::android.graphics.drawable.Drawable._scheduleSelf3935 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.Drawable._unscheduleSelf3936 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.Drawable._setAlpha3937 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable._setColorFilter3938 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable._setColorFilter3939 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.drawable.Drawable._clearColorFilter3940 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V");
			global::android.graphics.drawable.Drawable._isStateful3941 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.Drawable._getCurrent3942 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._setLevel3943 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z");
			global::android.graphics.drawable.Drawable._getLevel3944 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I");
			global::android.graphics.drawable.Drawable._setVisible3945 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.Drawable._isVisible3946 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z");
			global::android.graphics.drawable.Drawable._getOpacity3947 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.Drawable._resolveOpacity3948 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I");
			global::android.graphics.drawable.Drawable._getTransparentRegion3949 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;");
			global::android.graphics.drawable.Drawable._onStateChange3950 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.Drawable._onLevelChange3951 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.Drawable._onBoundsChange3952 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._getIntrinsicWidth3953 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.Drawable._getIntrinsicHeight3954 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.Drawable._getMinimumWidth3955 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.Drawable._getMinimumHeight3956 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.Drawable._getPadding3957 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.Drawable._mutate3958 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromStream3959 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream3960 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream3961 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXml3962 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXmlInner3963 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromPath3964 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._getConstantState3965 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.Drawable._Drawable3966 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _draw3967;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._draw3967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._draw3967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3968;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setAlpha3968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._setAlpha3968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter3969;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setColorFilter3969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._setColorFilter3969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity3970;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._getOpacity3970);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_.staticClass, global::android.graphics.drawable.Drawable_._getOpacity3970);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable_._draw3967 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable_._setAlpha3968 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable_._setColorFilter3969 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable_._getOpacity3970 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "getOpacity", "()I");
		}
	}
}
