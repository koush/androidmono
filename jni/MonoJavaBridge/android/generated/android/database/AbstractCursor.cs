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
			internal static global::MonoJavaBridge.MethodId _deliverSelfNotifications4327;
			public override bool deliverSelfNotifications() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications4327);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications4327);
			}
			internal static global::MonoJavaBridge.MethodId _onChange4328;
			public override void onChange(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver._onChange4328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._onChange4328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SelfContentObserver4329;
			public SelfContentObserver(android.database.AbstractCursor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver4329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor$SelfContentObserver"));
				global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications4327 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z");
				global::android.database.AbstractCursor.SelfContentObserver._onChange4328 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V");
				global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver4329 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4330;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._finalize4330);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._finalize4330);
		}
		internal static global::MonoJavaBridge.MethodId _getShort4331;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getInt4332;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong4333;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getFloat4334;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _getDouble4335;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _close4336;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._close4336);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._close4336);
		}
		internal static global::MonoJavaBridge.MethodId _getString4337;
		public abstract global::java.lang.String getString(int arg0);
		internal static global::MonoJavaBridge.MethodId _isFirst4338;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isFirst4338);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFirst4338);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4339;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isClosed4339);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isClosed4339);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4340;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getPosition4340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getPosition4340);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4341;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getExtras4341)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getExtras4341)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4342;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._registerContentObserver4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerContentObserver4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4343;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._unregisterContentObserver4343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterContentObserver4343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4344;
		public virtual global::android.database.CursorWindow getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getWindow4344)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWindow4344)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _getCount4345;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _move4346;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._move4346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._move4346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4347;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToPosition4347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPosition4347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4348;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToFirst4348);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToFirst4348);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4349;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToLast4349);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToLast4349);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4350;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToNext4350);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToNext4350);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4351;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._moveToPrevious4351);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._moveToPrevious4351);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4352;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isLast4352);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isLast4352);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4353;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isBeforeFirst4353);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isBeforeFirst4353);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4354;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isAfterLast4354);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isAfterLast4354);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4355;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnIndex4355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndex4355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4356;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnIndexOrThrow4356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnIndexOrThrow4356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4357;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnName4357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnName4357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4358;
		public abstract global::java.lang.String[] getColumnNames();
		internal static global::MonoJavaBridge.MethodId _getColumnCount4359;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor._getColumnCount4359);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getColumnCount4359);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4360;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getBlob4360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getBlob4360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4361;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._copyStringToBuffer4361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._copyStringToBuffer4361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4362;
		public abstract bool isNull(int arg0);
		internal static global::MonoJavaBridge.MethodId _deactivate4363;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._deactivate4363);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._deactivate4363);
		}
		internal static global::MonoJavaBridge.MethodId _requery4364;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._requery4364);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._requery4364);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4365;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._registerDataSetObserver4365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._registerDataSetObserver4365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4366;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._unregisterDataSetObserver4366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._unregisterDataSetObserver4366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4367;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._setNotificationUri4367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._setNotificationUri4367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4368;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._getWantsAllOnMoveCalls4368);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getWantsAllOnMoveCalls4368);
		}
		internal static global::MonoJavaBridge.MethodId _respond4369;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._respond4369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._respond4369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onChange4370;
		protected virtual void onChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._onChange4370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onChange4370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4371;
		public virtual bool onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._onMove4371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._onMove4371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow4372;
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._fillWindow4372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._fillWindow4372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFieldUpdated4373;
		protected virtual bool isFieldUpdated(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor._isFieldUpdated4373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._isFieldUpdated4373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdatedField4374;
		protected virtual global::java.lang.Object getUpdatedField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor._getUpdatedField4374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._getUpdatedField4374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPosition4375;
		protected virtual void checkPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.AbstractCursor._checkPosition4375);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._checkPosition4375);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCursor4376;
		public AbstractCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.AbstractCursor.staticClass, global::android.database.AbstractCursor._AbstractCursor4376);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
			global::android.database.AbstractCursor._finalize4330 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "finalize", "()V");
			global::android.database.AbstractCursor._getShort4331 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getShort", "(I)S");
			global::android.database.AbstractCursor._getInt4332 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getInt", "(I)I");
			global::android.database.AbstractCursor._getLong4333 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getLong", "(I)J");
			global::android.database.AbstractCursor._getFloat4334 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractCursor._getDouble4335 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractCursor._close4336 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "close", "()V");
			global::android.database.AbstractCursor._getString4337 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._isFirst4338 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isFirst", "()Z");
			global::android.database.AbstractCursor._isClosed4339 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isClosed", "()Z");
			global::android.database.AbstractCursor._getPosition4340 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getPosition", "()I");
			global::android.database.AbstractCursor._getExtras4341 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.AbstractCursor._registerContentObserver4342 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._unregisterContentObserver4343 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.AbstractCursor._getWindow4344 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.AbstractCursor._getCount4345 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getCount", "()I");
			global::android.database.AbstractCursor._move4346 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "move", "(I)Z");
			global::android.database.AbstractCursor._moveToPosition4347 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.database.AbstractCursor._moveToFirst4348 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z");
			global::android.database.AbstractCursor._moveToLast4349 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z");
			global::android.database.AbstractCursor._moveToNext4350 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z");
			global::android.database.AbstractCursor._moveToPrevious4351 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z");
			global::android.database.AbstractCursor._isLast4352 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isLast", "()Z");
			global::android.database.AbstractCursor._isBeforeFirst4353 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.database.AbstractCursor._isAfterLast4354 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z");
			global::android.database.AbstractCursor._getColumnIndex4355 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnIndexOrThrow4356 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.AbstractCursor._getColumnName4357 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnNames4358 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.AbstractCursor._getColumnCount4359 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I");
			global::android.database.AbstractCursor._getBlob4360 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B");
			global::android.database.AbstractCursor._copyStringToBuffer4361 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.AbstractCursor._isNull4362 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isNull", "(I)Z");
			global::android.database.AbstractCursor._deactivate4363 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "deactivate", "()V");
			global::android.database.AbstractCursor._requery4364 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "requery", "()Z");
			global::android.database.AbstractCursor._registerDataSetObserver4365 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._unregisterDataSetObserver4366 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.AbstractCursor._setNotificationUri4367 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.AbstractCursor._getWantsAllOnMoveCalls4368 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.AbstractCursor._respond4369 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.AbstractCursor._onChange4370 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V");
			global::android.database.AbstractCursor._onMove4371 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z");
			global::android.database.AbstractCursor._fillWindow4372 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.AbstractCursor._isFieldUpdated4373 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z");
			global::android.database.AbstractCursor._getUpdatedField4374 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;");
			global::android.database.AbstractCursor._checkPosition4375 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "checkPosition", "()V");
			global::android.database.AbstractCursor._AbstractCursor4376 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getShort4377;
		public override short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.AbstractCursor_._getShort4377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getShort4377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4378;
		public override int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor_._getInt4378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getInt4378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4379;
		public override long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.AbstractCursor_._getLong4379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getLong4379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4380;
		public override float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.AbstractCursor_._getFloat4380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getFloat4380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4381;
		public override double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.AbstractCursor_._getDouble4381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getDouble4381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4382;
		public override global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_._getString4382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getString4382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCount4383;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.AbstractCursor_._getCount4383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getCount4383);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4384;
		public override global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_._getColumnNames4384)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._getColumnNames4384)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4385;
		public override bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor_._isNull4385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.AbstractCursor_.staticClass, global::android.database.AbstractCursor_._isNull4385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.AbstractCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/AbstractCursor"));
			global::android.database.AbstractCursor_._getShort4377 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getShort", "(I)S");
			global::android.database.AbstractCursor_._getInt4378 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getInt", "(I)I");
			global::android.database.AbstractCursor_._getLong4379 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getLong", "(I)J");
			global::android.database.AbstractCursor_._getFloat4380 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getFloat", "(I)F");
			global::android.database.AbstractCursor_._getDouble4381 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getDouble", "(I)D");
			global::android.database.AbstractCursor_._getString4382 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.AbstractCursor_._getCount4383 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getCount", "()I");
			global::android.database.AbstractCursor_._getColumnNames4384 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.AbstractCursor_._isNull4385 = @__env.GetMethodIDNoThrow(global::android.database.AbstractCursor_.staticClass, "isNull", "(I)Z");
		}
	}
}
