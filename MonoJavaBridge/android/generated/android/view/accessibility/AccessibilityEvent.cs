namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.accessibility.AccessibilityEvent._m0) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.CharSequence getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getClassName", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._m1) as java.lang.CharSequence;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.CharSequence getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getPackageName", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._m2) as java.lang.CharSequence;
		}
		public new global::java.util.List Text
		{
			get
			{
				return getText();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.util.List getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getText", "()Ljava/util/List;", ref global::android.view.accessibility.AccessibilityEvent._m3) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isChecked", "()Z", ref global::android.view.accessibility.AccessibilityEvent._m4);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setChecked", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isEnabled", "()Z", ref global::android.view.accessibility.AccessibilityEvent._m6);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEnabled", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public bool isPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isPassword", "()Z", ref global::android.view.accessibility.AccessibilityEvent._m8);
		}
		public new bool Password
		{
			set
			{
				setPassword(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void setPassword(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setPassword", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FullScreen
		{
			set
			{
				setFullScreen(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void setFullScreen(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setFullScreen", "(Z)V", ref global::android.view.accessibility.AccessibilityEvent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public bool isFullScreen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "isFullScreen", "()Z", ref global::android.view.accessibility.AccessibilityEvent._m11);
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
		private static global::MonoJavaBridge.MethodId _m12;
		public int getEventType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventType", "()I", ref global::android.view.accessibility.AccessibilityEvent._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public void setEventType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventType", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public int getItemCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getItemCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public void setItemCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setItemCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m16;
		public int getCurrentItemIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getCurrentItemIndex", "()I", ref global::android.view.accessibility.AccessibilityEvent._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void setCurrentItemIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setCurrentItemIndex", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m18;
		public int getFromIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getFromIndex", "()I", ref global::android.view.accessibility.AccessibilityEvent._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void setFromIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setFromIndex", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m20;
		public int getAddedCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getAddedCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public void setAddedCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setAddedCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m22;
		public int getRemovedCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getRemovedCount", "()I", ref global::android.view.accessibility.AccessibilityEvent._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public void setRemovedCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setRemovedCount", "(I)V", ref global::android.view.accessibility.AccessibilityEvent._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m24;
		public long getEventTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getEventTime", "()J", ref global::android.view.accessibility.AccessibilityEvent._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public void setEventTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setEventTime", "(J)V", ref global::android.view.accessibility.AccessibilityEvent._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public void setClassName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setClassName", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setClassName(string arg0)
		{
			setClassName((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public void setPackageName(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setPackageName", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m28;
		public global::java.lang.CharSequence getBeforeText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getBeforeText", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._m28) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public void setBeforeText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setBeforeText", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m30;
		public global::java.lang.CharSequence getContentDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;", ref global::android.view.accessibility.AccessibilityEvent._m30) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public void setContentDescription(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V", ref global::android.view.accessibility.AccessibilityEvent._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m32;
		public global::android.os.Parcelable getParcelableData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "getParcelableData", "()Landroid/os/Parcelable;", ref global::android.view.accessibility.AccessibilityEvent._m32) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public void setParcelableData(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "setParcelableData", "(Landroid/os/Parcelable;)V", ref global::android.view.accessibility.AccessibilityEvent._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::android.view.accessibility.AccessibilityEvent obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityEvent._m34.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityEvent._m34 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "()Landroid/view/accessibility/AccessibilityEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._m34)) as android.view.accessibility.AccessibilityEvent;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static global::android.view.accessibility.AccessibilityEvent obtain(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityEvent._m35.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityEvent._m35 = @__env.GetStaticMethodIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.accessibility.AccessibilityEvent>(@__env.CallStaticObjectMethod(android.view.accessibility.AccessibilityEvent.staticClass, global::android.view.accessibility.AccessibilityEvent._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.accessibility.AccessibilityEvent;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "recycle", "()V", ref global::android.view.accessibility.AccessibilityEvent._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public void initFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "initFromParcel", "(Landroid/os/Parcel;)V", ref global::android.view.accessibility.AccessibilityEvent._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.accessibility.AccessibilityEvent._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.accessibility.AccessibilityEvent.staticClass, "describeContents", "()I", ref global::android.view.accessibility.AccessibilityEvent._m39);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR5875;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.accessibility.AccessibilityEvent.staticClass, _CREATOR5875)) as android.os.Parcelable_Creator;
			}
		}
		static AccessibilityEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityEvent"));
			global::android.view.accessibility.AccessibilityEvent._CREATOR5875 = @__env.GetStaticFieldIDNoThrow(global::android.view.accessibility.AccessibilityEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
