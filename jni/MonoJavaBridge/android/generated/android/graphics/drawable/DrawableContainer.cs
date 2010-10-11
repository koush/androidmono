namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DrawableContainer()
		{
			InitJNI();
		}
		protected DrawableContainer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_))]
		public abstract partial class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DrawableContainerState()
			{
				InitJNI();
			}
			protected DrawableContainerState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3971;
			public override int getChangingConfigurations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3971);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3971);
			}
			internal static global::MonoJavaBridge.MethodId _isStateful3972;
			public virtual bool isStateful() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3972);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3972);
			}
			internal static global::MonoJavaBridge.MethodId _getOpacity3973;
			public virtual int getOpacity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3973);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3973);
			}
			internal static global::MonoJavaBridge.MethodId _getChildCount3974;
			public virtual int getChildCount() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3974);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3974);
			}
			internal static global::MonoJavaBridge.MethodId _addChild3975;
			public virtual int addChild(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getChildren3976;
			public virtual global::android.graphics.drawable.Drawable[] getChildren() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3976)) as android.graphics.drawable.Drawable[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3976)) as android.graphics.drawable.Drawable[];
			}
			internal static global::MonoJavaBridge.MethodId _setVariablePadding3977;
			public virtual void setVariablePadding(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getConstantPadding3978;
			public virtual global::android.graphics.Rect getConstantPadding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3978)) as android.graphics.Rect;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3978)) as android.graphics.Rect;
			}
			internal static global::MonoJavaBridge.MethodId _setConstantSize3979;
			public virtual void setConstantSize(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isConstantSize3980;
			public virtual bool isConstantSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3980);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3980);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantWidth3981;
			public virtual int getConstantWidth() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3981);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3981);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantHeight3982;
			public virtual int getConstantHeight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3982);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3982);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumWidth3983;
			public virtual int getConstantMinimumWidth() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3983);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3983);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumHeight3984;
			public virtual int getConstantMinimumHeight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3984);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3984);
			}
			internal static global::MonoJavaBridge.MethodId _growArray3985;
			public virtual void growArray(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _canConstantState3986;
			public virtual bool canConstantState() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3986);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3986);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations3971 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful3972 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity3973 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount3974 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild3975 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren3976 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding3977 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding3978 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize3979 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize3980 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth3981 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight3982 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth3983 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight3984 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray3985 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState3986 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState))]
		public sealed partial class DrawableContainerState_ : android.graphics.drawable.DrawableContainer.DrawableContainerState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DrawableContainerState_()
			{
				InitJNI();
			}
			internal DrawableContainerState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable3987;
			public override global::android.graphics.drawable.Drawable newDrawable() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable3987)) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable3987)) as android.graphics.drawable.Drawable;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable3987 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw3988;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._draw3988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._draw3988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3989;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3989);
		}
		internal static global::MonoJavaBridge.MethodId _setDither3990;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setDither3990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setDither3990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3991;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setAlpha3991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setAlpha3991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter3992;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setColorFilter3992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setColorFilter3992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful3993;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._isStateful3993);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._isStateful3993);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent3994;
		public override global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getCurrent3994)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getCurrent3994)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible3995;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setVisible3995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setVisible3995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity3996;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getOpacity3996);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getOpacity3996);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange3997;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onStateChange3997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onStateChange3997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange3998;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onLevelChange3998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onLevelChange3998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange3999;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onBoundsChange3999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onBoundsChange3999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4000;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth4000);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth4000);
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4001;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight4001);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight4001);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth4002;
		public override int getMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getMinimumWidth4002);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumWidth4002);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight4003;
		public override int getMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getMinimumHeight4003);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumHeight4003);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4004;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getPadding4004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getPadding4004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4005;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._mutate4005)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._mutate4005)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4006;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getConstantState4006)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getConstantState4006)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable4007;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._invalidateDrawable4007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._invalidateDrawable4007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable4008;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._scheduleDrawable4008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._scheduleDrawable4008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable4009;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable4009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable4009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _selectDrawable4010;
		public virtual bool selectDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._selectDrawable4010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._selectDrawable4010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConstantState4011;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setConstantState4011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setConstantState4011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DrawableContainer4012;
		public DrawableContainer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._DrawableContainer4012);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.DrawableContainer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer"));
			global::android.graphics.drawable.DrawableContainer._draw3988 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations3989 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.DrawableContainer._setDither3990 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.DrawableContainer._setAlpha3991 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.DrawableContainer._setColorFilter3992 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.DrawableContainer._isStateful3993 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.DrawableContainer._getCurrent3994 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._setVisible3995 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.DrawableContainer._getOpacity3996 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.DrawableContainer._onStateChange3997 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.DrawableContainer._onLevelChange3998 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._onBoundsChange3999 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth4000 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight4001 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth4002 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight4003 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getPadding4004 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.DrawableContainer._mutate4005 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._getConstantState4006 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable4007 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable4008 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable4009 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.DrawableContainer._selectDrawable4010 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._setConstantState4011 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V");
			global::android.graphics.drawable.DrawableContainer._DrawableContainer4012 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
		}
	}
}
