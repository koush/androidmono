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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.accessibility.AccessibilityEvent._toString15506) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._getClassName15507) as java.lang.CharSequence;
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._getPackageName15508) as java.lang.CharSequence;
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;", ref global::android.view.accessibility.AccessibilityEvent._getText15509) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isChecked15510;
		public bool isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z", ref global::android.view.accessibility.AccessibilityEvent._isChecked15510);
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._setChecked15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled15512;
		public bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z", ref global::android.view.accessibility.AccessibilityEvent._isEnabled15512);
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._setEnabled15513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPassword15514;
		public bool isPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z", ref global::android.view.accessibility.AccessibilityEvent._isPassword15514);
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._setPassword15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._setFullScreen15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFullScreen15517;
		public bool isFullScreen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z", ref global::android.view.accessibility.AccessibilityEvent._isFullScreen15517);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I", ref global::android.view.accessibility.AccessibilityEvent._getEventType15518);
		}
		internal static global::MonoJavaBridge.MethodId _setEventType15519;
		public void setEventType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setEventType15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._getItemCount15520);
		}
		internal static global::MonoJavaBridge.MethodId _setItemCount15521;
		public void setItemCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setItemCount15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I", ref global::android.view.accessibility.AccessibilityEvent._getCurrentItemIndex15522);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentItemIndex15523;
		public void setCurrentItemIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setCurrentItemIndex15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I", ref global::android.view.accessibility.AccessibilityEvent._getFromIndex15524);
		}
		internal static global::MonoJavaBridge.MethodId _setFromIndex15525;
		public void setFromIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setFromIndex15525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._getAddedCount15526);
		}
		internal static global::MonoJavaBridge.MethodId _setAddedCount15527;
		public void setAddedCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setAddedCount15527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._getRemovedCount15528);
		}
		internal static global::MonoJavaBridge.MethodId _setRemovedCount15529;
		public void setRemovedCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._setRemovedCount15529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J", ref global::android.view.accessibility.AccessibilityEvent._getEventTime15530);
		}
		internal static global::MonoJavaBridge.MethodId _setEventTime15531;
		public void setEventTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V", ref global::android.view.accessibility.AccessibilityEvent._setEventTime15531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClassName15532;
		public void setClassName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._setClassName15532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPackageName15533;
		public void setPackageName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._setPackageName15533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._getBeforeText15534) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setBeforeText15535;
		public void setBeforeText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._setBeforeText15535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._getContentDescription15536) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription15537;
		public void setContentDescription(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._setContentDescription15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;", ref global::android.view.accessibility.AccessibilityEvent._getParcelableData15538) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setParcelableData15539;
		public void setParcelableData(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V", ref global::android.view.accessibility.AccessibilityEvent._setParcelableData15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain15540;
		public static global::android.view.accessibility.AccessibilityEvent obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityEvent._obtain15540.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityEvent._obtain15540 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain15540)) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain15541;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityEvent._obtain15541.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityEvent._obtain15541 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._obtain15541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.accessibility.AccessibilityEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle15542;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V", ref global::android.view.accessibility.AccessibilityEvent._recycle15542);
		}
		internal static global::MonoJavaBridge.MethodId _initFromParcel15543;
		public void initFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V", ref global::android.view.accessibility.AccessibilityEvent._initFromParcel15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15544;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.accessibility.AccessibilityEvent._writeToParcel15544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15545;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I", ref global::android.view.accessibility.AccessibilityEvent._describeContents15545);
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
			global::android.view.accessibility.AccessibilityEvent._CREATOR15556 = @__env.GetStaticFieldIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
