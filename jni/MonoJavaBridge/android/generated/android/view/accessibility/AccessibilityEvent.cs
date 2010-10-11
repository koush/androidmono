namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityEvent()
		{
			InitJNI();
		}
		internal AccessibilityEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString9841;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._toString9841)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._toString9841)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClassName9842;
		public global::java.lang.CharSequence getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getClassName9842)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getClassName9842)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName9843;
		public global::java.lang.CharSequence getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getPackageName9843)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getPackageName9843)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getText9844;
		public global::java.util.List getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getText9844)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getText9844)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isChecked9845;
		public bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isChecked9845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isChecked9845);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked9846;
		public void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setChecked9846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setChecked9846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled9847;
		public bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isEnabled9847);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isEnabled9847);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled9848;
		public void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEnabled9848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEnabled9848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPassword9849;
		public bool isPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isPassword9849);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isPassword9849);
		}
		internal static global::MonoJavaBridge.MethodId _setPassword9850;
		public void setPassword(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPassword9850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPassword9850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFullScreen9851;
		public void setFullScreen(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFullScreen9851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFullScreen9851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFullScreen9852;
		public bool isFullScreen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isFullScreen9852);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isFullScreen9852);
		}
		internal static global::MonoJavaBridge.MethodId _getEventType9853;
		public int getEventType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventType9853);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventType9853);
		}
		internal static global::MonoJavaBridge.MethodId _setEventType9854;
		public void setEventType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventType9854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventType9854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItemCount9855;
		public int getItemCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getItemCount9855);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getItemCount9855);
		}
		internal static global::MonoJavaBridge.MethodId _setItemCount9856;
		public void setItemCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setItemCount9856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setItemCount9856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentItemIndex9857;
		public int getCurrentItemIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9857);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentItemIndex9858;
		public void setCurrentItemIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFromIndex9859;
		public int getFromIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getFromIndex9859);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getFromIndex9859);
		}
		internal static global::MonoJavaBridge.MethodId _setFromIndex9860;
		public void setFromIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFromIndex9860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFromIndex9860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAddedCount9861;
		public int getAddedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getAddedCount9861);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getAddedCount9861);
		}
		internal static global::MonoJavaBridge.MethodId _setAddedCount9862;
		public void setAddedCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setAddedCount9862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setAddedCount9862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRemovedCount9863;
		public int getRemovedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getRemovedCount9863);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getRemovedCount9863);
		}
		internal static global::MonoJavaBridge.MethodId _setRemovedCount9864;
		public void setRemovedCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setRemovedCount9864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setRemovedCount9864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime9865;
		public long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventTime9865);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventTime9865);
		}
		internal static global::MonoJavaBridge.MethodId _setEventTime9866;
		public void setEventTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventTime9866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventTime9866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClassName9867;
		public void setClassName(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setClassName9867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setClassName9867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPackageName9868;
		public void setPackageName(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPackageName9868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPackageName9868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPackageName(string arg0)
		{
			setPackageName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getBeforeText9869;
		public global::java.lang.CharSequence getBeforeText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getBeforeText9869)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getBeforeText9869)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setBeforeText9870;
		public void setBeforeText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setBeforeText9870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setBeforeText9870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setBeforeText(string arg0)
		{
			setBeforeText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getContentDescription9871;
		public global::java.lang.CharSequence getContentDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getContentDescription9871)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getContentDescription9871)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription9872;
		public void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setContentDescription9872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setContentDescription9872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableData9873;
		public global::android.os.Parcelable getParcelableData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getParcelableData9873)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getParcelableData9873)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setParcelableData9874;
		public void setParcelableData(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setParcelableData9874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setParcelableData9874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain9875;
		public static global::android.view.accessibility.AccessibilityEvent obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain9875)) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9876;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain9876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9877;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._recycle9877);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._recycle9877);
		}
		internal static global::MonoJavaBridge.MethodId _initFromParcel9878;
		public void initFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._initFromParcel9878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._initFromParcel9878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9879;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._writeToParcel9879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._writeToParcel9879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9880;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._describeContents9880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._describeContents9880);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR9881;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityEvent"));
			global::android.view.accessibility.AccessibilityEvent._toString9841 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.accessibility.AccessibilityEvent._getClassName9842 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getPackageName9843 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getText9844 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;");
			global::android.view.accessibility.AccessibilityEvent._isChecked9845 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setChecked9846 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isEnabled9847 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setEnabled9848 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isPassword9849 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setPassword9850 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._setFullScreen9851 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isFullScreen9852 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z");
			global::android.view.accessibility.AccessibilityEvent._getEventType9853 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I");
			global::android.view.accessibility.AccessibilityEvent._setEventType9854 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getItemCount9855 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setItemCount9856 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex9857 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex9858 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getFromIndex9859 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setFromIndex9860 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getAddedCount9861 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setAddedCount9862 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount9863 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount9864 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getEventTime9865 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J");
			global::android.view.accessibility.AccessibilityEvent._setEventTime9866 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V");
			global::android.view.accessibility.AccessibilityEvent._setClassName9867 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._setPackageName9868 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getBeforeText9869 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setBeforeText9870 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getContentDescription9871 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setContentDescription9872 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getParcelableData9873 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;");
			global::android.view.accessibility.AccessibilityEvent._setParcelableData9874 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V");
			global::android.view.accessibility.AccessibilityEvent._obtain9875 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._obtain9876 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._recycle9877 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V");
			global::android.view.accessibility.AccessibilityEvent._initFromParcel9878 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.accessibility.AccessibilityEvent._writeToParcel9879 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.accessibility.AccessibilityEvent._describeContents9880 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I");
		}
	}
}
