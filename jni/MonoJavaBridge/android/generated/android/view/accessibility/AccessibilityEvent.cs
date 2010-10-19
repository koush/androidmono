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
		internal static global::MonoJavaBridge.MethodId _toString10387;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._toString10387)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._toString10387)) as java.lang.String;
		}
		public new string ClassName
		{
			get
			{
				return getClassName().toString();
			}
			set
			{
				setClassName((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName10388;
		public global::java.lang.CharSequence getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getClassName10388)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getClassName10388)) as java.lang.CharSequence;
		}
		public new string PackageName
		{
			get
			{
				return getPackageName().toString();
			}
			set
			{
				setPackageName((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName10389;
		public global::java.lang.CharSequence getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getPackageName10389)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getPackageName10389)) as java.lang.CharSequence;
		}
		public new global::java.util.List Text
		{
			get
			{
				return getText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText10390;
		public global::java.util.List getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getText10390)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getText10390)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isChecked10391;
		public bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isChecked10391);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isChecked10391);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked10392;
		public void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setChecked10392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setChecked10392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10393;
		public bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isEnabled10393);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isEnabled10393);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled10394;
		public void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEnabled10394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEnabled10394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPassword10395;
		public bool isPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isPassword10395);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isPassword10395);
		}
		internal static global::MonoJavaBridge.MethodId _setPassword10396;
		public void setPassword(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPassword10396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPassword10396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFullScreen10397;
		public void setFullScreen(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFullScreen10397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFullScreen10397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFullScreen10398;
		public bool isFullScreen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isFullScreen10398);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isFullScreen10398);
		}
		public new int EventType
		{
			get
			{
				return getEventType();
			}
			set
			{
				setEventType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventType10399;
		public int getEventType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventType10399);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventType10399);
		}
		internal static global::MonoJavaBridge.MethodId _setEventType10400;
		public void setEventType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventType10400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventType10400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ItemCount
		{
			get
			{
				return getItemCount();
			}
			set
			{
				setItemCount(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemCount10401;
		public int getItemCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getItemCount10401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getItemCount10401);
		}
		internal static global::MonoJavaBridge.MethodId _setItemCount10402;
		public void setItemCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setItemCount10402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setItemCount10402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentItemIndex
		{
			get
			{
				return getCurrentItemIndex();
			}
			set
			{
				setCurrentItemIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentItemIndex10403;
		public int getCurrentItemIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex10403);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex10403);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentItemIndex10404;
		public void setCurrentItemIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex10404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex10404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int FromIndex
		{
			get
			{
				return getFromIndex();
			}
			set
			{
				setFromIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFromIndex10405;
		public int getFromIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getFromIndex10405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getFromIndex10405);
		}
		internal static global::MonoJavaBridge.MethodId _setFromIndex10406;
		public void setFromIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFromIndex10406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFromIndex10406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AddedCount
		{
			get
			{
				return getAddedCount();
			}
			set
			{
				setAddedCount(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddedCount10407;
		public int getAddedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getAddedCount10407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getAddedCount10407);
		}
		internal static global::MonoJavaBridge.MethodId _setAddedCount10408;
		public void setAddedCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setAddedCount10408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setAddedCount10408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RemovedCount
		{
			get
			{
				return getRemovedCount();
			}
			set
			{
				setRemovedCount(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemovedCount10409;
		public int getRemovedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getRemovedCount10409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getRemovedCount10409);
		}
		internal static global::MonoJavaBridge.MethodId _setRemovedCount10410;
		public void setRemovedCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setRemovedCount10410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setRemovedCount10410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
			set
			{
				setEventTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime10411;
		public long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventTime10411);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventTime10411);
		}
		internal static global::MonoJavaBridge.MethodId _setEventTime10412;
		public void setEventTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventTime10412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventTime10412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClassName10413;
		public void setClassName(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setClassName10413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setClassName10413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPackageName10414;
		public void setPackageName(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPackageName10414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPackageName10414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPackageName(string arg0)
		{
			setPackageName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string BeforeText
		{
			get
			{
				return getBeforeText().toString();
			}
			set
			{
				setBeforeText((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBeforeText10415;
		public global::java.lang.CharSequence getBeforeText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getBeforeText10415)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getBeforeText10415)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setBeforeText10416;
		public void setBeforeText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setBeforeText10416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setBeforeText10416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setBeforeText(string arg0)
		{
			setBeforeText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string ContentDescription
		{
			get
			{
				return getContentDescription().toString();
			}
			set
			{
				setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentDescription10417;
		public global::java.lang.CharSequence getContentDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getContentDescription10417)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getContentDescription10417)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription10418;
		public void setContentDescription(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setContentDescription10418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setContentDescription10418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new global::android.os.Parcelable ParcelableData
		{
			get
			{
				return getParcelableData();
			}
			set
			{
				setParcelableData(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableData10419;
		public global::android.os.Parcelable getParcelableData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getParcelableData10419)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getParcelableData10419)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setParcelableData10420;
		public void setParcelableData(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setParcelableData10420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setParcelableData10420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain10421;
		public static global::android.view.accessibility.AccessibilityEvent obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain10421)) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain10422;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain10422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle10423;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._recycle10423);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._recycle10423);
		}
		internal static global::MonoJavaBridge.MethodId _initFromParcel10424;
		public void initFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._initFromParcel10424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._initFromParcel10424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10425;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._writeToParcel10425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._writeToParcel10425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10426;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._describeContents10426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._describeContents10426);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR10427;
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
			global::android.view.accessibility.AccessibilityEvent._toString10387 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.accessibility.AccessibilityEvent._getClassName10388 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getPackageName10389 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getText10390 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;");
			global::android.view.accessibility.AccessibilityEvent._isChecked10391 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setChecked10392 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isEnabled10393 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setEnabled10394 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isPassword10395 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setPassword10396 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._setFullScreen10397 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isFullScreen10398 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z");
			global::android.view.accessibility.AccessibilityEvent._getEventType10399 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I");
			global::android.view.accessibility.AccessibilityEvent._setEventType10400 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getItemCount10401 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setItemCount10402 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex10403 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex10404 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getFromIndex10405 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setFromIndex10406 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getAddedCount10407 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setAddedCount10408 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount10409 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount10410 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getEventTime10411 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J");
			global::android.view.accessibility.AccessibilityEvent._setEventTime10412 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V");
			global::android.view.accessibility.AccessibilityEvent._setClassName10413 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._setPackageName10414 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getBeforeText10415 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setBeforeText10416 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getContentDescription10417 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setContentDescription10418 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getParcelableData10419 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;");
			global::android.view.accessibility.AccessibilityEvent._setParcelableData10420 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V");
			global::android.view.accessibility.AccessibilityEvent._obtain10421 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._obtain10422 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._recycle10423 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V");
			global::android.view.accessibility.AccessibilityEvent._initFromParcel10424 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.accessibility.AccessibilityEvent._writeToParcel10425 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.accessibility.AccessibilityEvent._describeContents10426 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I");
		}
	}
}
