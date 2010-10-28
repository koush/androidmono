namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15506;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._toString15506)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._toString15506)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getClassName15507;
		public global::java.lang.CharSequence getClassName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getClassName15507)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getClassName15507)) as java.lang.CharSequence;
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
		internal static global::MonoJavaBridge.MethodId _getPackageName15508;
		public global::java.lang.CharSequence getPackageName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getPackageName15508)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getPackageName15508)) as java.lang.CharSequence;
		}
		public new global::java.util.List Text
		{
			get
			{
				return getText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText15509;
		public global::java.util.List getText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getText15509)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getText15509)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isChecked15510;
		public bool isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isChecked15510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isChecked15510);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setChecked15511;
		public void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setChecked15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setChecked15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled15512;
		public bool isEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isEnabled15512);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isEnabled15512);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled15513;
		public void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEnabled15513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEnabled15513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPassword15514;
		public bool isPassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isPassword15514);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isPassword15514);
		}
		public new bool Password
		{
			set
			{
				setPassword(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPassword15515;
		public void setPassword(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPassword15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPassword15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FullScreen
		{
			set
			{
				setFullScreen(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFullScreen15516;
		public void setFullScreen(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFullScreen15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFullScreen15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFullScreen15517;
		public bool isFullScreen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._isFullScreen15517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._isFullScreen15517);
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
		internal static global::MonoJavaBridge.MethodId _getEventType15518;
		public int getEventType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventType15518);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventType15518);
		}
		internal static global::MonoJavaBridge.MethodId _setEventType15519;
		public void setEventType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventType15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventType15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getItemCount15520;
		public int getItemCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getItemCount15520);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getItemCount15520);
		}
		internal static global::MonoJavaBridge.MethodId _setItemCount15521;
		public void setItemCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setItemCount15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setItemCount15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrentItemIndex15522;
		public int getCurrentItemIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex15522);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex15522);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentItemIndex15523;
		public void setCurrentItemIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFromIndex15524;
		public int getFromIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getFromIndex15524);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getFromIndex15524);
		}
		internal static global::MonoJavaBridge.MethodId _setFromIndex15525;
		public void setFromIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setFromIndex15525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setFromIndex15525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAddedCount15526;
		public int getAddedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getAddedCount15526);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getAddedCount15526);
		}
		internal static global::MonoJavaBridge.MethodId _setAddedCount15527;
		public void setAddedCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setAddedCount15527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setAddedCount15527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRemovedCount15528;
		public int getRemovedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getRemovedCount15528);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getRemovedCount15528);
		}
		internal static global::MonoJavaBridge.MethodId _setRemovedCount15529;
		public void setRemovedCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setRemovedCount15529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setRemovedCount15529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEventTime15530;
		public long getEventTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getEventTime15530);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getEventTime15530);
		}
		internal static global::MonoJavaBridge.MethodId _setEventTime15531;
		public void setEventTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setEventTime15531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setEventTime15531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClassName15532;
		public void setClassName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setClassName15532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setClassName15532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPackageName15533;
		public void setPackageName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setPackageName15533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setPackageName15533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBeforeText15534;
		public global::java.lang.CharSequence getBeforeText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getBeforeText15534)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getBeforeText15534)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setBeforeText15535;
		public void setBeforeText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setBeforeText15535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setBeforeText15535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentDescription15536;
		public global::java.lang.CharSequence getContentDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getContentDescription15536)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getContentDescription15536)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription15537;
		public void setContentDescription(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setContentDescription15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setContentDescription15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getParcelableData15538;
		public global::android.os.Parcelable getParcelableData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._getParcelableData15538)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._getParcelableData15538)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setParcelableData15539;
		public void setParcelableData(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._setParcelableData15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._setParcelableData15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain15540;
		public static global::android.view.accessibility.AccessibilityEvent obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain15540)) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain15541;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain15541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle15542;
		public void recycle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._recycle15542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._recycle15542);
		}
		internal static global::MonoJavaBridge.MethodId _initFromParcel15543;
		public void initFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._initFromParcel15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._initFromParcel15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15544;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._writeToParcel15544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._writeToParcel15544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15545;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent._describeContents15545);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._describeContents15545);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR15556;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.accessibility.AccessibilityEvent.staticClass, _CREATOR15556)) as android.os.Parcelable_Creator;
			}
		}
		static AccessibilityEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityEvent"));
			global::android.view.accessibility.AccessibilityEvent._toString15506 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.accessibility.AccessibilityEvent._getClassName15507 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getPackageName15508 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._getText15509 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;");
			global::android.view.accessibility.AccessibilityEvent._isChecked15510 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setChecked15511 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isEnabled15512 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setEnabled15513 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isPassword15514 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z");
			global::android.view.accessibility.AccessibilityEvent._setPassword15515 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._setFullScreen15516 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V");
			global::android.view.accessibility.AccessibilityEvent._isFullScreen15517 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z");
			global::android.view.accessibility.AccessibilityEvent._getEventType15518 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I");
			global::android.view.accessibility.AccessibilityEvent._setEventType15519 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getItemCount15520 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setItemCount15521 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex15522 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex15523 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getFromIndex15524 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I");
			global::android.view.accessibility.AccessibilityEvent._setFromIndex15525 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getAddedCount15526 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setAddedCount15527 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getRemovedCount15528 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I");
			global::android.view.accessibility.AccessibilityEvent._setRemovedCount15529 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V");
			global::android.view.accessibility.AccessibilityEvent._getEventTime15530 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J");
			global::android.view.accessibility.AccessibilityEvent._setEventTime15531 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V");
			global::android.view.accessibility.AccessibilityEvent._setClassName15532 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._setPackageName15533 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getBeforeText15534 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setBeforeText15535 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getContentDescription15536 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;");
			global::android.view.accessibility.AccessibilityEvent._setContentDescription15537 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V");
			global::android.view.accessibility.AccessibilityEvent._getParcelableData15538 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;");
			global::android.view.accessibility.AccessibilityEvent._setParcelableData15539 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V");
			global::android.view.accessibility.AccessibilityEvent._obtain15540 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._obtain15541 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			global::android.view.accessibility.AccessibilityEvent._recycle15542 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V");
			global::android.view.accessibility.AccessibilityEvent._initFromParcel15543 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.accessibility.AccessibilityEvent._writeToParcel15544 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.accessibility.AccessibilityEvent._describeContents15545 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I");
			global::android.view.accessibility.AccessibilityEvent._CREATOR15556 = @__env.GetStaticFieldIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
