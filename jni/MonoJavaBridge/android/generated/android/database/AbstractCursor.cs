namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.AbstractCursor_))]
	public abstract partial class AbstractCursor : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCursor()
		{
			InitJNI();
		}
		protected AbstractCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class SelfContentObserver : android.database.ContentObserver
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SelfContentObserver()
			{
				InitJNI();
			}
			protected SelfContentObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _deliverSelfNotifications2429;
			public override bool deliverSelfNotifications() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2429);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2429);
			}
			internal static global::MonoJavaBridge.MethodId _onChange2430;
			public override void onChange(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver._onChange2430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._onChange2430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SelfContentObserver2431;
			public SelfContentObserver(android.database.AbstractCursor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver2431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor$SelfContentObserver"));
				global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2429 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z");
				global::android.database.AbstractCursor.SelfContentObserver._onChange2430 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V");
				global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver2431 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize2432;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._finalize2432);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._finalize2432);
		}
		internal static global::MonoJavaBridge.MethodId _getShort2433;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getInt2434;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong2435;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getFloat2436;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _getDouble2437;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _close2438;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._close2438);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._close2438);
		}
		internal static global::MonoJavaBridge.MethodId _getString2439;
		public abstract global::java.lang.String getString(int arg0);
		internal static global::MonoJavaBridge.MethodId _isFirst2440;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isFirst2440);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFirst2440);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed2441;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isClosed2441);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isClosed2441);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition2442;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getPosition2442);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getPosition2442);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras2443;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getExtras2443)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getExtras2443)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2444;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._registerContentObserver2444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerContentObserver2444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2445;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._unregisterContentObserver2445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterContentObserver2445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindow2446;
		public virtual global::android.database.CursorWindow getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getWindow2446)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWindow2446)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getCount2447;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _move2448;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._move2448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._move2448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition2449;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToPosition2449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPosition2449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst2450;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToFirst2450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToFirst2450);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast2451;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToLast2451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToLast2451);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext2452;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToNext2452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToNext2452);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious2453;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToPrevious2453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPrevious2453);
		}
		internal static global::MonoJavaBridge.MethodId _isLast2454;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isLast2454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isLast2454);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst2455;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isBeforeFirst2455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isBeforeFirst2455);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast2456;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isAfterLast2456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isAfterLast2456);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex2457;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnIndex2457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndex2457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow2458;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnIndexOrThrow2458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndexOrThrow2458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName2459;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnName2459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnName2459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2460;
		public abstract global::java.lang.String[] getColumnNames();
		internal static global::MonoJavaBridge.MethodId _getColumnCount2461;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnCount2461);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnCount2461);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2462;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getBlob2462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getBlob2462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2463;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._copyStringToBuffer2463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._copyStringToBuffer2463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2464;
		public abstract bool isNull(int arg0);
		internal static global::MonoJavaBridge.MethodId _deactivate2465;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._deactivate2465);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._deactivate2465);
		}
		internal static global::MonoJavaBridge.MethodId _requery2466;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._requery2466);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._requery2466);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver2467;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._registerDataSetObserver2467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerDataSetObserver2467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver2468;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._unregisterDataSetObserver2468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterDataSetObserver2468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri2469;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._setNotificationUri2469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._setNotificationUri2469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls2470;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._getWantsAllOnMoveCalls2470);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWantsAllOnMoveCalls2470);
		}
		internal static global::MonoJavaBridge.MethodId _respond2471;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._respond2471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._respond2471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onChange2472;
		protected virtual void onChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._onChange2472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onChange2472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove2473;
		public virtual bool onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._onMove2473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onMove2473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow2474;
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._fillWindow2474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._fillWindow2474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFieldUpdated2475;
		protected virtual bool isFieldUpdated(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isFieldUpdated2475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFieldUpdated2475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdatedField2476;
		protected virtual global::java.lang.Object getUpdatedField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getUpdatedField2476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getUpdatedField2476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition2477;
		protected virtual void checkPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._checkPosition2477);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._checkPosition2477);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCursor2478;
		public AbstractCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._AbstractCursor2478);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
			global::android.database.AbstractCursor._finalize2432 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "finalize", "()V");
			global::android.database.AbstractCursor._getShort2433 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractCursor._getInt2434 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractCursor._getLong2435 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractCursor._getFloat2436 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractCursor._getDouble2437 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractCursor._close2438 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "close", "()V");
			global::android.database.AbstractCursor._getString2439 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._isFirst2440 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isFirst", "()Z");
			global::android.database.AbstractCursor._isClosed2441 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isClosed", "()Z");
			global::android.database.AbstractCursor._getPosition2442 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getPosition", "()I");
			global::android.database.AbstractCursor._getExtras2443 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.AbstractCursor._registerContentObserver2444 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._unregisterContentObserver2445 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._getWindow2446 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractCursor._getCount2447 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getCount", "()I");
			global::android.database.AbstractCursor._move2448 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "move", "(I)Z");
			global::android.database.AbstractCursor._moveToPosition2449 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.database.AbstractCursor._moveToFirst2450 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z");
			global::android.database.AbstractCursor._moveToLast2451 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z");
			global::android.database.AbstractCursor._moveToNext2452 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z");
			global::android.database.AbstractCursor._moveToPrevious2453 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z");
			global::android.database.AbstractCursor._isLast2454 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isLast", "()Z");
			global::android.database.AbstractCursor._isBeforeFirst2455 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.database.AbstractCursor._isAfterLast2456 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z");
			global::android.database.AbstractCursor._getColumnIndex2457 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnIndexOrThrow2458 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnName2459 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnNames2460 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnCount2461 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I");
			global::android.database.AbstractCursor._getBlob2462 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractCursor._copyStringToBuffer2463 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractCursor._isNull2464 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractCursor._deactivate2465 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "deactivate", "()V");
			global::android.database.AbstractCursor._requery2466 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "requery", "()Z");
			global::android.database.AbstractCursor._registerDataSetObserver2467 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._unregisterDataSetObserver2468 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._setNotificationUri2469 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.AbstractCursor._getWantsAllOnMoveCalls2470 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.AbstractCursor._respond2471 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.AbstractCursor._onChange2472 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V");
			global::android.database.AbstractCursor._onMove2473 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z");
			global::android.database.AbstractCursor._fillWindow2474 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.AbstractCursor._isFieldUpdated2475 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z");
			global::android.database.AbstractCursor._getUpdatedField2476 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;");
			global::android.database.AbstractCursor._checkPosition2477 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractCursor._AbstractCursor2478 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.AbstractCursor))]
	public sealed partial class AbstractCursor_ : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCursor_()
		{
			InitJNI();
		}
		internal AbstractCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort2479;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.AbstractCursor_._getShort2479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getShort2479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2480;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor_._getInt2480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getInt2480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2481;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.AbstractCursor_._getLong2481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getLong2481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2482;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.AbstractCursor_._getFloat2482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getFloat2482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2483;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.AbstractCursor_._getDouble2483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getDouble2483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString2484;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_._getString2484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getString2484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCount2485;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor_._getCount2485);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getCount2485);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2486;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_._getColumnNames2486)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getColumnNames2486)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull2487;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor_._isNull2487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._isNull2487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
			global::android.database.AbstractCursor_._getShort2479 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getShort", "(I)S");
			global::android.database.AbstractCursor_._getInt2480 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getInt", "(I)I");
			global::android.database.AbstractCursor_._getLong2481 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getLong", "(I)J");
			global::android.database.AbstractCursor_._getFloat2482 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractCursor_._getDouble2483 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractCursor_._getString2484 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor_._getCount2485 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getCount", "()I");
			global::android.database.AbstractCursor_._getColumnNames2486 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.AbstractCursor_._isNull2487 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "isNull", "(I)Z");
		}
	}
}
