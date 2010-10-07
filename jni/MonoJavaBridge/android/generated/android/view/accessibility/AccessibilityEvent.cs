namespace android.view.accessibility
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static AccessibilityEvent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.accessibility.AccessibilityEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.accessibility.AccessibilityEvent(@__env);
			}
		}
		internal AccessibilityEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9494;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._toString9494));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._toString9494));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassName9495;
		public global::java.lang.CharSequence getClassName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getClassName9495));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getClassName9495));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName9496;
		public global::java.lang.CharSequence getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getPackageName9496));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getPackageName9496));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText9497;
		public global::java.util.List getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getText9497));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getText9497));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked9498;
		public bool isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isChecked9498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isChecked9498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked9499;
		public void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setChecked9499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setChecked9499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled9500;
		public bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isEnabled9500);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isEnabled9500);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled9501;
		public void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEnabled9501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEnabled9501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPassword9502;
		public bool isPassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isPassword9502);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isPassword9502);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPassword9503;
		public void setPassword(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setPassword9503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPassword9503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFullScreen9504;
		public void setFullScreen(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setFullScreen9504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFullScreen9504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFullScreen9505;
		public bool isFullScreen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent._isFullScreen9505);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isFullScreen9505);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventType9506;
		public int getEventType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getEventType9506);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventType9506);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEventType9507;
		public void setEventType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEventType9507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventType9507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemCount9508;
		public int getItemCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getItemCount9508);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getItemCount9508);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItemCount9509;
		public void setItemCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setItemCount9509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setItemCount9509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentItemIndex9510;
		public int getCurrentItemIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9510);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9510);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentItemIndex9511;
		public void setCurrentItemIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFromIndex9512;
		public int getFromIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getFromIndex9512);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getFromIndex9512);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFromIndex9513;
		public void setFromIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setFromIndex9513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFromIndex9513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAddedCount9514;
		public int getAddedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getAddedCount9514);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getAddedCount9514);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAddedCount9515;
		public void setAddedCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setAddedCount9515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setAddedCount9515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemovedCount9516;
		public int getRemovedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._getRemovedCount9516);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getRemovedCount9516);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRemovedCount9517;
		public void setRemovedCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setRemovedCount9517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setRemovedCount9517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime9518;
		public long getEventTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.accessibility.AccessibilityEvent._getEventTime9518);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventTime9518);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEventTime9519;
		public void setEventTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setEventTime9519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventTime9519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClassName9520;
		public void setClassName(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setClassName9520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setClassName9520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPackageName9521;
		public void setPackageName(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setPackageName9521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPackageName9521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setPackageName(string arg0)
		{
			setPackageName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBeforeText9522;
		public global::java.lang.CharSequence getBeforeText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getBeforeText9522));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getBeforeText9522));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBeforeText9523;
		public void setBeforeText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setBeforeText9523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setBeforeText9523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setBeforeText(string arg0)
		{
			setBeforeText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentDescription9524;
		public global::java.lang.CharSequence getContentDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getContentDescription9524));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getContentDescription9524));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentDescription9525;
		public void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setContentDescription9525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setContentDescription9525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableData9526;
		public global::android.os.Parcelable getParcelableData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent._getParcelableData9526));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getParcelableData9526));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParcelableData9527;
		public void setParcelableData(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._setParcelableData9527, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setParcelableData9527, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain9528;
		public static global::android.view.accessibility.AccessibilityEvent obtain() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain9528));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain9529;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.accessibility.AccessibilityEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain9529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle9530;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._recycle9530);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._recycle9530);
		}
		internal static global::net.sf.jni4net.jni.MethodId _initFromParcel9531;
		public void initFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._initFromParcel9531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._initFromParcel9531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9532;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent._writeToParcel9532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._writeToParcel9532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9533;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent._describeContents9533);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._describeContents9533);
		}
		public static int INVALID_POSITION
		{
			get
			{
				return -1;
			}
		}
		public static int MAX_TEXT_LENGTH
		{
			get
			{
				return 500;
			}
		}
		public static int TYPE_VIEW_CLICKED
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_VIEW_LONG_CLICKED
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_VIEW_SELECTED
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_VIEW_FOCUSED
		{
			get
			{
				return 8;
			}
		}
		public static int TYPE_VIEW_TEXT_CHANGED
		{
			get
			{
				return 16;
			}
		}
		public static int TYPE_WINDOW_STATE_CHANGED
		{
			get
			{
				return 32;
			}
		}
		public static int TYPE_NOTIFICATION_STATE_CHANGED
		{
			get
			{
				return 64;
			}
		}
		public static int TYPES_ALL_MASK
		{
			get
			{
				return -1;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9534;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__class;
			global::android.view.accessibility.AccessibilityEvent._toString9494 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.accessibility.AccessibilityEvent._getClassName9495 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getPackageName9496 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getText9497 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;");
			global::android.view.accessibility.AccessibilityEvent._isChecked9498 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setChecked9499 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isEnabled9500 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setEnabled9501 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isPassword9502 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setPassword9503 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._setFullScreen9504 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isFullScreen9505 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z");
			global::android.view.accessibility.AccessibilityEvent._getEventType9506 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I");
			global::android.view.accessibility.AccessibilityEvent._setEventType9507 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getItemCount9508 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setItemCount9509 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9510 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9511 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getFromIndex9512 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setFromIndex9513 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getAddedCount9514 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setAddedCount9515 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount9516 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount9517 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getEventTime9518 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J");
			global::android.view.accessibility.AccessibilityEvent._setEventTime9519 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V");
			global::android.view.accessibility.AccessibilityEvent._setClassName9520 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._setPackageName9521 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getBeforeText9522 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setBeforeText9523 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getContentDescription9524 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setContentDescription9525 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getParcelableData9526 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;");
			global::android.view.accessibility.AccessibilityEvent._setParcelableData9527 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V");
			global::android.view.accessibility.AccessibilityEvent._obtain9528 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._obtain9529 = @__env.GetStaticMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._recycle9530 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V");
			global::android.view.accessibility.AccessibilityEvent._initFromParcel9531 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.accessibility.AccessibilityEvent._writeToParcel9532 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.accessibility.AccessibilityEvent._describeContents9533 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I");
		}
	}
}
