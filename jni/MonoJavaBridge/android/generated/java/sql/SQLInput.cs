namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLInput_))]
	public partial interface SQLInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object readObject();
		int readInt();
		byte[] readBytes();
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		bool readBoolean();
		double readDouble();
		global::java.lang.String readString();
		global::java.sql.Array readArray();
		bool wasNull();
		global::java.math.BigDecimal readBigDecimal();
		global::java.sql.Date readDate();
		global::java.sql.Time readTime();
		global::java.sql.Timestamp readTimestamp();
		global::java.io.Reader readCharacterStream();
		global::java.io.InputStream readAsciiStream();
		global::java.io.InputStream readBinaryStream();
		global::java.sql.Ref readRef();
		global::java.sql.Blob readBlob();
		global::java.sql.Clob readClob();
		global::java.net.URL readURL();
		global::java.lang.String readNString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLInput))]
	internal sealed partial class SQLInput_ : java.lang.Object, SQLInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLInput_()
		{
			InitJNI();
		}
		internal SQLInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readObject24982;
		global::java.lang.Object java.sql.SQLInput.readObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readObject24982)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readObject24982)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readInt24983;
		int java.sql.SQLInput.readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.SQLInput_._readInt24983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readInt24983);
		}
		internal static global::MonoJavaBridge.MethodId _readBytes24984;
		byte[] java.sql.SQLInput.readBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBytes24984)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBytes24984)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readLong24985;
		long java.sql.SQLInput.readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.SQLInput_._readLong24985);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readLong24985);
		}
		internal static global::MonoJavaBridge.MethodId _readByte24986;
		byte java.sql.SQLInput.readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.SQLInput_._readByte24986);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readByte24986);
		}
		internal static global::MonoJavaBridge.MethodId _readShort24987;
		short java.sql.SQLInput.readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.SQLInput_._readShort24987);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readShort24987);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat24988;
		float java.sql.SQLInput.readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.SQLInput_._readFloat24988);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readFloat24988);
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean24989;
		bool java.sql.SQLInput.readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._readBoolean24989);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBoolean24989);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble24990;
		double java.sql.SQLInput.readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.SQLInput_._readDouble24990);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readDouble24990);
		}
		internal static global::MonoJavaBridge.MethodId _readString24991;
		global::java.lang.String java.sql.SQLInput.readString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readString24991)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readString24991)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readArray24992;
		global::java.sql.Array java.sql.SQLInput.readArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readArray24992)) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readArray24992)) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24993;
		bool java.sql.SQLInput.wasNull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_._wasNull24993);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._wasNull24993);
		}
		internal static global::MonoJavaBridge.MethodId _readBigDecimal24994;
		global::java.math.BigDecimal java.sql.SQLInput.readBigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBigDecimal24994)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBigDecimal24994)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _readDate24995;
		global::java.sql.Date java.sql.SQLInput.readDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readDate24995)) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readDate24995)) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _readTime24996;
		global::java.sql.Time java.sql.SQLInput.readTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTime24996)) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readTime24996)) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _readTimestamp24997;
		global::java.sql.Timestamp java.sql.SQLInput.readTimestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readTimestamp24997)) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readTimestamp24997)) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _readCharacterStream24998;
		global::java.io.Reader java.sql.SQLInput.readCharacterStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readCharacterStream24998)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readCharacterStream24998)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _readAsciiStream24999;
		global::java.io.InputStream java.sql.SQLInput.readAsciiStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readAsciiStream24999)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readAsciiStream24999)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBinaryStream25000;
		global::java.io.InputStream java.sql.SQLInput.readBinaryStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBinaryStream25000)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBinaryStream25000)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readRef25001;
		global::java.sql.Ref java.sql.SQLInput.readRef()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readRef25001)) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readRef25001)) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _readBlob25002;
		global::java.sql.Blob java.sql.SQLInput.readBlob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readBlob25002)) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readBlob25002)) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _readClob25003;
		global::java.sql.Clob java.sql.SQLInput.readClob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readClob25003)) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readClob25003)) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _readURL25004;
		global::java.net.URL java.sql.SQLInput.readURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readURL25004)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readURL25004)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _readNString25005;
		global::java.lang.String java.sql.SQLInput.readNString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLInput_._readNString25005)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLInput_.staticClass, global::java.sql.SQLInput_._readNString25005)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLInput"));
			global::java.sql.SQLInput_._readObject24982 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.sql.SQLInput_._readInt24983 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readInt", "()I");
			global::java.sql.SQLInput_._readBytes24984 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBytes", "()[B");
			global::java.sql.SQLInput_._readLong24985 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readLong", "()J");
			global::java.sql.SQLInput_._readByte24986 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readByte", "()B");
			global::java.sql.SQLInput_._readShort24987 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readShort", "()S");
			global::java.sql.SQLInput_._readFloat24988 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readFloat", "()F");
			global::java.sql.SQLInput_._readBoolean24989 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBoolean", "()Z");
			global::java.sql.SQLInput_._readDouble24990 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDouble", "()D");
			global::java.sql.SQLInput_._readString24991 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readString", "()Ljava/lang/String;");
			global::java.sql.SQLInput_._readArray24992 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readArray", "()Ljava/sql/Array;");
			global::java.sql.SQLInput_._wasNull24993 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "wasNull", "()Z");
			global::java.sql.SQLInput_._readBigDecimal24994 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBigDecimal", "()Ljava/math/BigDecimal;");
			global::java.sql.SQLInput_._readDate24995 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readDate", "()Ljava/sql/Date;");
			global::java.sql.SQLInput_._readTime24996 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTime", "()Ljava/sql/Time;");
			global::java.sql.SQLInput_._readTimestamp24997 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readTimestamp", "()Ljava/sql/Timestamp;");
			global::java.sql.SQLInput_._readCharacterStream24998 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.SQLInput_._readAsciiStream24999 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readBinaryStream25000 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBinaryStream", "()Ljava/io/InputStream;");
			global::java.sql.SQLInput_._readRef25001 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readRef", "()Ljava/sql/Ref;");
			global::java.sql.SQLInput_._readBlob25002 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readBlob", "()Ljava/sql/Blob;");
			global::java.sql.SQLInput_._readClob25003 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readClob", "()Ljava/sql/Clob;");
			global::java.sql.SQLInput_._readURL25004 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readURL", "()Ljava/net/URL;");
			global::java.sql.SQLInput_._readNString25005 = @__env.GetMethodIDNoThrow(global::java.sql.SQLInput_.staticClass, "readNString", "()Ljava/lang/String;");
		}
	}
}
